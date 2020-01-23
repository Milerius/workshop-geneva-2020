# Workshop part 2

In this part we will make our first call to rpc with the atomic dex API: `Electrum`

This RPC call allows us to activate coin.

We will activate 2 coins: RICK/MORTY

To do this we need a json library: Newtonsoft.json

You can add it with the command `dotnet add package Newtonsoft.Json`

Docs: https://developers.komodoplatform.com/basic-docs/atomicdex/atomicdex-api.html#electrum

## Architecture

- Static class MM2Client with http rpc call
- Name of the rpc call + Request/Answer (contains Json serialization/deserialization of the rpc call)
- Main is a static task that wait for the http answer, and print http output to the console.

You can use: https://app.quicktype.io/ for generate CSharp Serialization/Deserialization Files, don't forget to adjust namespace and remove redundant stuff.

## Postpone

When you will successfully enable RICK/MORTY: you should have the following output:

`{"address":"RFbTSFDfaZYX5yMv5KZA7DVbhwLA9XgrXY","balance":"0","coin":"MORTY","locked_by_swaps":"0","required_confirmations":1,"result":"success"}`

For the next step please go to https://www.atomicexplorer.com/#/faucet/morty and https://www.atomicexplorer.com/#/faucet/rick

and enter the address that you got from the successful answer, you will get some rick and morty.