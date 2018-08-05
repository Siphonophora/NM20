#r @"C:\Users\mike\Documents\GitHub\NM20\NM20\packages\FSharp.Data.2.4.6\lib\net45\FSharp.Data.dll"


// "open" brings a .NET namespace into visibility
open System.Net
open System
open System.IO
open FSharp.Data


let url = "https://www.cqww.com/publiclogs/2015cw/"
let mainDir = @"C:\NM20\ContestLogs"
let filetype = ".log"

let getAllHrefs (filetype:string) (url:string) = 
    let results = HtmlDocument.Load(url)
    let links = 
        results.Descendants ["a"]
        |> Seq.choose (fun x -> 
               x.TryGetAttribute("href")
               |> Option.map (fun a -> url + a.Value())
        )
    let files =
        links
        |> Seq.filter (fun (url) -> 
                        url.EndsWith(filetype))
        |> Seq.toArray
    files


let getAllLogURLs = getAllHrefs filetype



let downloadFile url = 
    let contest = System.IO.Path.GetFileName(System.IO.Path.GetDirectoryName(url))
    let file = System.IO.Path.GetFileName(url)
    let directory = mainDir + "\\" + contest + "\\Real\\"
    Directory.CreateDirectory(directory) |> ignore
    match Http.Request(url).Body with
        | Text text -> 
            printfn "Got text content: %s" text
            File.WriteAllText(directory + "\\" + file,text)
        | Binary bytes -> 
            printfn "Got %d bytes of binary content" bytes.Length



getAllLogURLs url |> Array.map downloadFile |> ignore

