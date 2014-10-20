Project description and purpose 
--------------------------------
“ChessCraft” is a multilayer strategy board game. The game itself is based upon the old, well-known Chess game. The difference is that I made a lot of enhancements in order to create a dynamic environment, which requires a constant shifting of the player’s strategy to fulfil the final goal. Most of the non-programming code components in the game (unit portraits, music, secrets, wallpapers, etc.) are based upon existing games developed by the company Blizzard Entertainment. That’s why I DON’T TAKE ANY CREDITS OR MONEY for the creation of this product. It is made primarily for the educational purpose of “Telerik Academy”! The logic is created on the C# programming language and the visualization is made with XAML. 


Rules of the game 
------------------
On the 8x8 board, there are two teams – The Alliance and The Horde. Each team consists of 16 units which have health points, can move, attack, defend. All units start from level 0 and they can earn levels during the game.  The unit names and behaviour is explained in details in the file ‘units.xls’ (it should be in the same folder as this file). When two units collide, there is a battle. The attacking unit damage is subtracted from the defending unit’s health and the attacker receives damage equal to the defending unit’s defence modifier. 
In order to win you have to kill the enemy Healing unit and the enemy King unit (Priest/King for The Alliance and Shaman/Warchief for The Horde). 