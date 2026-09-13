# The two decisions

Everything in this project is drawn against these. Nothing else gets to disagree with them.

Fill this in during week 0, before drawing anything.

## Resolution

**320 × 180.**

Chosen because it scales by whole numbers to both targets: ×6 is exactly 1920 × 1080, and ×4 is
exactly 1280 × 720, which fits a Steam Deck screen with clean letterboxing. Whole-number scaling means
no resampling, so a pixel stays a square.

The cost, so it is not a surprise later: at this size, type has to be a pixel font. Any typeface with
real curves will mush.

| Setting | Value | Where |
|---|---|---|
| Viewport width | `320` | Project Settings → Display → Window |
| Viewport height | `180` | same |
| Stretch mode | `canvas_items` | same |
| Stretch aspect | `keep` | same |
| Default texture filter | `Nearest` | Project Settings → Rendering → Textures |

## Palette

Picked from https://lospec.com/palette-list — something dark and warm.

**Name:** Herbs n spices  
**Source:** lospec.com/palette-list/herbs-n-spices  
**Author:** Qirlfriend  
**Colours:** 16

```
#593a31
#39202e
#613140
#83443e
#c98d3f
#dac282
#9a945c
#6b6657
#384150
#6e7e8d
#90b5c6
#f5efe8
#ab99a4
#55516f
#463554
#17111a 
```

Load it into Aseprite as the project palette, so picking a colour that is not on this list is not
something you can do by accident.

## The rule

One resolution, one palette, no exceptions. Not for a background, not for a UI element, not for one
special effect.

This is the whole of what makes a set of assets look like they belong together, and it does not
require being good at drawing. Incoherent and skilled reads as broken. Clumsy and coherent reads as
style.
