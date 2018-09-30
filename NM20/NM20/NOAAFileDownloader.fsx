#r @"C:\Users\mike\Documents\GitHub\NM20\NM20\packages\FSharp.Data.2.4.6\lib\net45\FSharp.Data.dll"


// "open" brings a .NET namespace into visibility
open System.Net
open System
open System.IO
open FSharp.Data


let url = @"C:\temp\GOES16_ABI_FD_GEOCOLOR_.html"
let mainDir = @"C:\Users\mike\Dropbox\NOAA\GEOCOLOR"
let filetype = "10848x10848.jpg"


let getAllHrefs (filetype:string) (url:string) = 
    let fileText = File.ReadAllLines(url) |> String.Concat 
    let results = HtmlDocument.Parse(fileText)
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

let urlfix (badurl:string) =
    badurl.[36..]

getAllLogURLs url |> Array.map urlfix

let downloadFile url = 
    try
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
            File.WriteAllBytes(directory + "\\" + file,bytes)
     


getAllLogURLs url |> Array.map urlfix |> Array.map downloadFile |> ignore

