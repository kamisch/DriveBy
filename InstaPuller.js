import {JSO, Popup} from 'jso'

let config = {...}
let j = new JSO(config)

//authenticator
let client = new JSO({
    providerID: "Instagram",
    client_id: "47ce210662294ff2a6ac25b41378cc01",
    redirect_uri: "http://localhost:8080/" // The URL where you is redirected back, and where you perform run the callback() function.
    //authorization: "https://api.instagram.com/oauth/authorize/?client_id=CLIENT-ID&redirect_uri=REDIRECT-URI&response_type=code",
    //scopes: { request: ["https://www.googleapis.com/auth/userinfo.profile"]}
})

