// LINQPad's "Dump" extension method will eat just about anything!

123.Dump();
Regex.Match ("my favorite color is...", "colou?r").Dump();

//  Dump accepts an optional title for formatting:

TimeZoneInfo.Local.Dump ("Bet you never knew this type existed!");

// Dump returns exactly what it was given, so you can sneakily inject
// a Dump (or even many Dumps) *within* an expression. This is useful
// for monitoring a query as it progresses:


