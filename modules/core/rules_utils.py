from typing import Iterable, Iterator, List
import re

_SINGLE_OPS = set("lucdrtoODxT")  

_S_MULTI_RE = re.compile(r"^S(?P<delim>.)(?P<old>.*?)(?P=delim)(?P<new>.*?)(?P=delim)$", re.DOTALL)

def _tokenize_rule(rule: str) -> List[str]:
    tokens: List[str] = []
    i = 0
    n = len(rule)

    while i < n:
        ch = rule[i]

        if ch == '^':
            i += 1
            j = i
            while j < n and rule[j] not in ('^', '$', 's', 'S') and rule[j] not in _SINGLE_OPS:
                j += 1
            val = rule[i:j]
            if val:
                tokens.append('^' + val)
            i = j
            continue

        if ch == '$':
            i += 1
            j = i
            while j < n and rule[j] not in ('^', '$', 's', 'S') and rule[j] not in _SINGLE_OPS:
                j += 1
            val = rule[i:j]
            if val:
                tokens.append('$' + val)
            i = j
            continue

        if ch == 's' and i + 2 < n:
            x = rule[i+1]
            y = rule[i+2]
            tokens.append(f's{x}{y}')
            i += 3
            continue

        if ch == 'S' and i + 1 < n:
            delim = rule[i+1]
            k1 = rule.find(delim, i+2)
            if k1 == -1:
                i += 1
                continue
            k2 = rule.find(delim, k1+1)
            if k2 == -1:
                i += 1
                continue
            token_text = rule[i:k2+1]
            if _S_MULTI_RE.match(token_text):
                tokens.append(token_text)
                i = k2 + 1
                continue
            else:
                i += 1
                continue

        if ch in _SINGLE_OPS:
            tokens.append(ch)
            i += 1
            continue

        if ch.isspace():
            i += 1
            continue

        j = i
        while j < n and rule[j] not in ('^', '$', 's', 'S') and rule[j] not in _SINGLE_OPS and not rule[j].isspace():
            j += 1
        literal = rule[i:j]
        if literal:
            tokens.append(literal)
        i = j

    return tokens


def load_rules_file(path: str) -> List[str]:
    rules = []
    with open(path, "r", encoding="utf-8", errors="ignore") as f:
        for ln in f:
            ln2 = ln.strip()
            if not ln2:
                continue
            if ln2.startswith("#"):
                continue
            if "#" in ln2:
                ln2 = ln2.split("#", 1)[0].strip()
                if not ln2:
                    continue
            rules.append(ln2)
    return rules

def _apply_tokens(word: str, tokens: List[str]) -> str:
    out = word
    for tok in tokens:
        if not tok:
            continue

        if tok[0] == '^':
            out = tok[1:] + out
            continue
        if tok[0] == '$':
            out = out + tok[1:]
            continue

        if tok.startswith('s') and len(tok) == 3:
            _, x, y = tok
            out = out.replace(x, y)
            continue

        if tok.startswith('S'):
            m = _S_MULTI_RE.match(tok)
            if m:
                old = m.group('old')
                new = m.group('new')
                if old:
                    out = out.replace(old, new)
                else:
                    out = out
            continue
        
        op = tok
        if op == 'l':
            out = out.lower()
        elif op == 'u':
            out = out.upper()
        elif op == 'c':
            out = out.capitalize()
        elif op == 'r':
            out = out[::-1]
        elif op == 'd':
            out = out + out
        elif op == 't' or op == 'T':
            out = ''.join(ch.lower() if ch.isupper() else ch.upper() for ch in out)
        elif op == 'o':
            if out:
                out = out[1:] + out[0]
        elif op == 'O':
            if out:
                out = out[-1] + out[:-1]
        elif op == 'D':
            out = out[1:] if len(out) > 0 else out
        elif op == 'x':
            out = out[:-1] if len(out) > 0 else out
    return out


def apply_rule(word: str, rule: str) -> str:
    try:
        tokens = _tokenize_rule(rule)
        out = _apply_tokens(word, tokens)
        return out
    except Exception:
        return word 


def generate_with_rules(bases: Iterable[str], rules: Iterable[str],
                        max_per_base: int | None = None) -> Iterator[str]:
    for base in bases:
        yield base
        produced = 0
        for r in rules:
            try:
                var = apply_rule(base, r)
            except Exception:
                continue
            if not var:
                continue
            if var == base:
                continue
            yield var
            produced += 1
            if max_per_base is not None and produced >= max_per_base:
                break


def rules_preview(bases: Iterable[str], rules: List[str], limit: int = 50) -> List[str]:
    out = []
    seen = set()
    gen = generate_with_rules(bases, rules, max_per_base=None)
    for v in gen:
        if v in seen:
            continue
        seen.add(v)
        out.append(v)
        if len(out) >= limit:
            break
    return out
