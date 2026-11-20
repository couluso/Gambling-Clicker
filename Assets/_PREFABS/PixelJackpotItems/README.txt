PIXEL JACKPOT - 50 16x16 casino & slot items
============================================

50 hand-crafted 16x16 pixel art items for slot machines, casino and lucky games, in 5 categories
(10 each), all in one consistent style: dark selective outline, top-left lighting, 4-tone shading.

CONTENTS
  Items/<Category>/<Item>.png           16x16 PNG per item, transparent background
  Scaled_x4/<Category>/<Item>.png       the same icon at 64x64 (nearest neighbour)
  Jackpot_Items_Sheet.png               all 50 items, 10x5 grid of 16x16 (160x80), one category per row
  Scaled_x4/Jackpot_Items_Sheet_x2/_x4  the sheet upscaled x2 / x4
  items.json                            name, category, file and sheet offset of every item
  Preview_All.png                       labelled preview

CATEGORIES
  Slot Symbols:     Cherries, Lemon, Orange, Plum, Grapes, Watermelon, Strawberry, Bell, Lucky Seven, Bar
  Lucky Charms:     Clover, Horseshoe, Star, Heart, Crown, Diamond, Ruby, Emerald, Sapphire, Rainbow
  Coins & Cash:     Gold Coin, Silver Coin, Coin Stack, Coin Pile, Banknote, Cash Stack, Money Bag, Gold Bar, Gold Bar Stack, Pot Of Gold
  Casino:           Dice, Red Chip, Blue Chip, Green Chip, Black Chip, Chip Stack, Ace Card, Card Hand, Roulette Wheel, Slot Machine
  Jackpot & Bonus:  Trophy, Medal, Gift Box, Golden Ticket, Slot Lever, Reel 777, Scratch Card, Multiplier X 2, Wild Badge, Treasure Chest

TIPS
  Use nearest-neighbour / "Point" filtering and integer scaling (x2, x3, x4...).
  Slot reels: stack the Slot Symbols vertically and scroll them - every symbol fits the same 16x16 cell.
  Unity: Filter Mode = Point, Compression = None, Sprite Mode = Multiple, Grid By Cell Size 16x16.
  Godot: Texture Filter = Nearest; AtlasTexture regions from items.json (sheet_x, sheet_y, 16, 16).
  Roblox: ResampleMode = Pixelated; ImageRectSize = 16x16, ImageRectOffset from items.json.

LICENSE
  CC0 1.0 - free for personal and commercial projects, no credit required (credit appreciated!).
  Please don't resell or redistribute the pack itself as an asset pack.
