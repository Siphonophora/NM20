
open System.IO
open System

type Frequency = Frequency of int
type Contest = Contest of string
type CallTime = CallTime of System.DateTime
type Callsign = Callsign of string

    

type Strength = Strength of int
type Zone = Zone of int


let basedir = @"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\2015cw\"
//let basedir = @"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\mediumlogs\"
//let basedir = @"C:\Users\mike\Dropbox\NM2O_Project\ContestLogs\Badlogs\"


let files = Directory.GetFiles (basedir + @"Real\")
let logSubmitters = files |> Array.map Path.GetFileNameWithoutExtension |> Array.toList

let readLog file = 
    printfn "Parsing file %s" file 
    let qsos = 
        File.ReadAllLines(file)
        |> Array.filter( fun (x) -> x.StartsWith("QSO:"))
        |> Array.toList
    qsos
   

let tryParseQso (qso:string) = 
    try
        //printfn "Row string: %s" qso 
        let fields = qso.Split([|' ';'\t';'\u00A0'|], System.StringSplitOptions.RemoveEmptyEntries)
        let csv =
                (System.Int32.Parse fields.[1]).ToString() + "," +
                fields.[2]+ "," +
                (System.DateTime.Parse (fields.[3] + " " + fields.[4].Substring(0,2) + ":" + fields.[4].Substring(2,2))).ToString() + "," +
                fields.[5]+ "," +
                (System.Int32.Parse fields.[6]).ToString() + "," +
                (System.Int32.Parse fields.[7]).ToString() + "," +
                fields.[8]+ "," +
                (System.Int32.Parse fields.[9]).ToString() + "," +
                (System.Int32.Parse fields.[10]).ToString()
        //printfn "CSV: %s" csv
        //printfn "Split Fields lines %A" fields 
        Some csv
    with _ -> 
        printfn "Skipped row: %s" qso
        None
        


let convertFile outdir file = 
    let callsign = Path.GetFileNameWithoutExtension file
    let outfile = outdir + callsign + ".log.csv"
    Directory.CreateDirectory(outdir) |> ignore
    let header = ["Frequency,Contest,CallTime,SentCallsign,SentStrength,SentZone,RecdCallsign,RecdStrength,RecdZone"]
    let csvs = readLog file |> List.map tryParseQso |> List.choose id
    let contents = header @ csvs
    File.WriteAllLines(outfile, contents) |> ignore


let convertToDir = convertFile (basedir + @"CSV\")

files |> Array.map convertToDir |> ignore


