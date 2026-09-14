---
name: verify
description: Check a claim about Godot or its C# API against the real documentation, the API reference or the compiler, rather than answering from memory, and quote what it actually says. Use when Rodrigo asks whether something is true, when an API detail matters, or when a previous answer needs confirming.
---

# Verify

Answer from the source, not from recall.

## Why this exists

Godot 4.x renamed a great deal of API across its minor versions, and your training has a cutoff. On
this machine you have already asserted `StandardMaterial3D.Specular`, which does not exist — the
property is `MetallicSpecular`, and the compiler found it, not you. A confidently wrong API detail
costs him an evening, which is exactly the failure the one-hour rule in `README.md` exists to stop.

Summaries are not sources either. A summary of the C# docs once claimed `delta` is a `float` and that
`Position.X = 5f;` works. The API reference said `double`, and the compiler rejected the line.

## How to answer

1. **Go to the source.** In order of authority:
   - **The compiler**, for anything about what C# accepts. A throwaway project outside this repo that
     builds or fails settles it.
   - **`GodotSharp.xml`**, in the .NET editor's `GodotSharp/Api/Debug` folder, for any C# name or
     signature. It lists every member exactly as C# spells it.
   - **`docs.godotengine.org`**, the class reference or the manual, for behaviour. Not a blog, not a
     forum post, not a remembered snippet.
2. **Quote the line that settles it**, and say where it came from.
3. **Answer the claim plainly**: true, false, or true-with-a-condition.
4. **Say if it contradicts you.** If the source disagrees with what you would have said from memory,
   say so out loud. That calibrates how much he should trust an unverified answer next time.

## If you cannot reach a source

Say that, say what you believe and how confident you are, and tell him where to check himself.
**Never present a remembered API detail as verified.**

## Hard limits

- **You may Read, fetch, and build a throwaway project outside this repo.** You may not write anything
  in this repo.
- No code in the answer, even to demonstrate the API. Name the signature; he types it.
