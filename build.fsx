#r "paket: groupref netcorebuild //"
#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core

Target.create "Clean" Target.DoNothing

Target.runOrDefault "Clean"