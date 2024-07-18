# WHSender-APIDocs

1-/auth ( important step , the first)
  POST : 
    ‘user’ string
    ‘token’ string
  Return: 
    ‘state’ string
    ‘qr’ url

2-/send
  POST:
    ‘user’ string
    ‘token’ string
    ‘content’ string
    ‘contacts’ list of numbers
    ‘is_random_code’ bool
    ‘file’ file ( if there no file set to null )
  Retrun:
    ‘state’

    
3-/state: get current state of account
4-/stop: temporary stop of process
5-/rasume: resume the process
6-/cancel: cancel the process
7-/reset: reset session for new account 
Send token , user in all paths from 3 to 7 in post request
