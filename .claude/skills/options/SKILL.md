---
name: options
description: Lay out two or three ways to build something in Godot, with their tradeoffs, and recommend one. No implementation. Use when Rodrigo asks how he should approach a feature, or which of several approaches to take.
---

# Options

He knows what he wants to happen. He does not yet know what the choices are. Give him the map, not
the route.

## For each approach

- **How it works**, in one or two sentences — the mechanism, not the API calls.
- **What it costs.** Complexity, how it fails, what it makes harder later. Be concrete; "less
  flexible" is not a cost, "you cannot interrupt it halfway" is.
- **When it is the right one.** The condition under which you would pick it over the others.

Two or three. Not five — a list that long is a way of not having an opinion.

## Then recommend

Name one, and give the reason in terms of *this* project: one screen, one enemy, six weeks, and a
hard rule against scope. The simplest thing that works is usually correct here, and the answer that
would be right for a shipping game is often wrong for this one.

Where a choice is genuinely close, say so rather than manufacturing a winner.

## Hard limits

- **No implementation.** Not the recommended one either. Name the nodes and methods involved so he
  can find them; stop there.
- **You may Read. You may not Edit or Write.**
- If one of the approaches would break a scope rule in `README.md`, say which rule and leave it out of
  the recommendation.
