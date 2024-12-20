* 1.2.8 -> improvements for status effect and guide point lookup for pieces and items
* 1.2.6 & .7 -> added translation tokens for items that provide equip effects
* 1.2.5 -> added StatusEffect translation model
* 1.2.4 -> updated dependencies and compiled for Valheim version 0.219.14 
* 1.2.3 -> now also provides RandomSpeak implementation
* 1.2.2 ->
    * can now also print guide points from prefabs (just locations seems not to be loaded with that)
* 1.2.0 ->
    * added looking up teleporters as child components in locations
* 1.1.3 ->
    * added "Pickable" type to model
* 1.1.2 ->
    * updated (no code change required) for Ashlands Valheim version 0.218.15
* 1.1.1 ->
    * fixed handling multiple types for prefabs, now it might get you the ultimate amount of translations, finally :)
* 1.1.0 ->
    * added a couple of new types to also get translations for them
    * compiled for 0.217.38
* 1.0.9 -> updated dependencies, compiled for 0.217.30
* 1.0.8 -> updated dependencies, compiled for 0.217.24
* 1.0.7 -> updated dependencies
* 1.0.6 ->
    * added HoverText type
* 1.0.5 ->
    * fixed issues not providing translations
    * added types Character, Beehive, CookingStation, Fermenter, Incinerator, MapTable, OfferingBowl, SapCollector,
      Smelter
    * string outputs in translation files will be sanity checked for non-word special characters (except "_")
    * if tokens were not changed in custom items from vanilla tokens, will also print the vanilla tokens
* 1.0.4 ->
    * updated Jotunn dependency
    * updated for Valheim version 0.217.14
* 1.0.3 -> updated Jotunn dependency
* 1.0.2 -> changed from writing .yaml to .yml (if that matters)
* 1.0.1 -> fixed duplicate mod name key error
* 1.0.0 -> first release
