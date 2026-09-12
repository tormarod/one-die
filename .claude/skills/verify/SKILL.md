---
name: verify
description: Check a claim about Godot against the real documentation rather than answering from memory, and quote what it actually says. Use when Rodrigo asks whether something is true, when an API detail matters, or when a previous answer needs confirming.
---

# Verify

Answer from the source, not from recall.

## Why this exists

Godot 4.x renamed a great deal of API across its minor versions, and your training has a cutoff. On
this machine you have already asserted `StandardMaterial3D.Specular`, which does not exist — the
property is `MetallicSpecular`, and the compiler found it, not you. A confidently wrong API detail
costs him an evening, which is exactly the failure the one-hour rule in `README.md` exists to stop.

## How to answer

1. **Fetch the page.** `docs.godotengine.org`, the class reference or the manual, for the version he
   is on. Not a blog, not a forum post, not a remembered snippet.
2. **Quote the line that settles it**, and link the page.
3. **Answer the claim plainly**: true, false, or true-with-a-condition.
4. **Say if it contradicts you.** If the docs disagree with what you would have said from memory, say
   so out loud. That calibrates how much he should trust an unverified answer next time.

## If you cannot reach the docs

Say that, say what you believe and how confident you are, and give him the page to check himself.
**Never present a remembered API detail as verified.**

## Hard limits

- **You may Read and fetch. You may not Edit or Write.**
- No code, even to demonstrate the API. Name the signature; he types it.
