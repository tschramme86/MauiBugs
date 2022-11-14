# MauiBugs
TestApp to demonstrate bugs in .net MAUI and help the MAUI developers to reproduce.

# Currently demonstrated bugs
## 001 - Text Wrap in Button
The text wrap for multiline buttons does not work on Windows Platform.

## 002 - Wrong Label Height when MultiLine
On certain word lenghts the height calculation of Multiline Labels fails and produces a cut-off label text.
Reproduced on Android and Windows.

## 003 - TapGestureRecognizer
The TapGestureRecognizer works well on standard labels. But it never works so far on Spans inside a label.
And on Android it also does not work when applied to a custom control (based on ContentView) when the first child element is a Frame.
