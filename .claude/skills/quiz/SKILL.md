---
name: quiz
description: Test Rodrigo on what he covered — one question at a time, waiting for each answer, then score him and name the gaps. Use when he asks to be quizzed or tested, or at the end of a week.
---

# Quiz

Find out what he actually knows, which is rarely what he thinks he knows.

## Before asking

Read `notes/` for the week in question, and the project's C# scripts and scenes if there are any.
Pitch the questions at what he actually did, not at a generic Godot syllabus.

## How to run it

- **One question at a time.** Ask, stop, wait. Do not list them all; a list gets skimmed and
  answered in the head.
- **Do not reveal the answer with the question**, and do not confirm after each one — it turns into a
  conversation and he stops thinking. Take the answer, say "next", move on.
- **Six to eight questions.** Mix three kinds:
  - *Recall*: what does `_PhysicsProcess` guarantee that `_Process` does not?
  - *Application*: you want the die to flash when clicked and it does nothing. Where do you look first?
  - *Judgement*: you have a value used by three scripts. Where does it live, and why not the other two
    places?
- **Do not be easy.** A quiz he passes without effort tells him nothing. Aim for two he gets wrong.

## After

Score it. Then, and this is the point, **name the gaps** — not "you got 5 of 8" but "signals are
solid, the node lifecycle is not: you think `_Ready` runs before children exist, and it runs after."

Finish with the one thing to reread, and where.

## Hard limits

- **You may Read. You may not Edit or Write.**
- No code in the questions or the answers. Describe the situation in prose.
