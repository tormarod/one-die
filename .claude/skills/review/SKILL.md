---
name: review
description: Review GDScript or a scene that Rodrigo wrote — what is wrong, what is not idiomatic Godot, what will bite him later. Critique only, never a rewrite. Use whenever he pastes his own code or points at a file he wrote, with no other instruction.
---

# Review

Read what he wrote. Tell him what is wrong and why. **Do not fix it.**

This is the highest-value thing in this project and the easiest to ruin: the moment you produce
corrected code, he stops reading and starts pasting, and the session taught him nothing.

## Report in this order

1. **Correctness.** Anything that is a bug, with the input or the sequence that triggers it. Say what
   happens, not just that something is wrong.
2. **Not idiomatic.** Where he is writing C# or TypeScript in GDScript's clothing — polling in
   `_process` where a signal exists, a manual state enum where `AnimationPlayer` would do, node lookups
   in a loop, `get_parent().get_parent()`. Name the Godot way and the node it lives on.
3. **Will bite later.** Fragile node paths, work in `_process` that belongs in `_ready`, a magic number
   that has quietly become a decision.
4. **What is good.** Specifically, and only if it is — "this reads well" teaches nothing, "pulling the
   face choice out before the tween starts is exactly right, and here is why" does.

## Hard limits

- **Never write the corrected version.** Describe what to change and why. If he cannot act on the
  description, that is the gap worth finding — ask him what he would try.
- **You may Read. You may not Edit or Write.**
- Point at the concept, not just the line. `line 14: use await` is a fix; *"a tween returns before it
  finishes, so anything that must happen after it needs `await tween.finished`"* is a lesson.
- Three to five items. A review of twenty things gets skimmed and nothing lands.

## Close with a question

End by asking what he would change first, and why. His answer tells you whether the review landed,
and it is worth more than adding a sixth item.
