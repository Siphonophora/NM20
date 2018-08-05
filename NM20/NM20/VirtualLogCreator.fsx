
open System.IO
open System

type Frequency = Frequency of int
type Contest = Contest of string
type CallTime = CallTime of System.DateTime
type Callsign = Callsign of string

    

type Strength = Strength of string
type Zone = Zone of string
type QSO = 
    {
        Frequency: Frequency
        Contest: Contest
        CallTime: CallTime
        SentCallsign: Callsign
        SentStrengh: Strength
        SentZone: Zone
        RecdCallsign: Callsign
        RecdStrengh: Strength
        RecdZone: Zone
    }

//let dir = @"C:\NM20\ContestLogs\2017cw\Real\"
let dir = @"C:\NM20\ContestLogs\mediumlogs\Real\"
//let dir = @"C:\NM20\ContestLogs\Badlogs\Real\"


let files = Directory.GetFiles dir 
let submittedLogs = files |> Array.map Path.GetFileNameWithoutExtension |> Array.toList

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
        let fields = qso.Split([|' ';'\t'|], System.StringSplitOptions.RemoveEmptyEntries)
        //printfn "Split Fields lines %A" fields 
        let qso =
            {
                Frequency = Frequency (System.Int32.Parse fields.[1])
                Contest = Contest fields.[2]
                CallTime = CallTime (System.DateTime.Parse (fields.[3] + " 11:06" ))
                SentCallsign = Callsign fields.[5]
                SentStrengh = Strength fields.[6]
                SentZone = Zone fields.[7]
                RecdCallsign = Callsign fields.[8]
                RecdStrengh = Strength fields.[9]
                RecdZone = Zone fields.[10]
            }
        Some qso
    with _ -> None

let tryparseLog log = readLog log |> List.map tryParseQso
let tryparseLogs logs = logs |> Array.map tryparseLog |> List.concat


let qsos = tryparseLogs files |> List.choose id

qsos.Length
