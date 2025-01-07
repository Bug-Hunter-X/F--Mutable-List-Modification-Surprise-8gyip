# F# Mutable List Modification Surprise

This example demonstrates a potential point of confusion when working with mutable lists in F#.  In contrast to how mutable variables are treated, mutable lists exhibit different behavior when their elements are modified.

The `bug.fs` file contains code that shows the difference between how modification of a primitive mutable value and modification of a mutable list leads to different observable effects. The `bugSolution.fs` file doesn't offer a direct solution to the bug, but rather explains the behavior and offers a way to approach such scenarios in a more predictable way.