#r @"C:\Users\mike\Documents\GitHub\NM20\NM20\packages\FSharp.Data.2.4.6\lib\net45\FSharp.Data.dll"

// "open" brings a .NET namespace into visibility
open System.Net
open System
open System.IO
open FSharp.Data


let basedir = @"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\minilogs\"
let file = @"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\minilogs\n0vd.log.csv" 

let files = Directory.GetFiles (basedir + @"CSV\")
let logSubmitters = files |> Array.map Path.GetFileNameWithoutExtension |> Array.toList

type qsoLog = CsvProvider<"C:\\temp\\test.csv">

let f = @"C:\temp\test.csv"
let getlog (file:string) = qsoLog.Load(file)

let log = getlog f
log.Rows

let logs = files |> Array.map getlog




logSubmitters
//let NonContestants = log.Filter(fun row ->
//    not (List.contains (row.RecdCallsign.ToLowerInvariant()) logSubmitters ))

 
let sdff (x:qsoLog.Row) = 
    let outfile = "C:\\junk\\" + x.RecdCallsign + ".csv"
    let header = ["Frequency,Contest,CallTime,SentCallsign,SentStrength,SentZone,RecdCallsign,RecdStrength,RecdZone"]
    match File.Exists(outfile) with
    | false -> File.WriteAllLines(outfile,header)
    | true -> File.WriteAllLines(outfile,header)
    //File.WriteAllLines(outfile,header)
    

log.Rows |> Seq.map sdff 






