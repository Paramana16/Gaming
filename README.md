# Gaming
Login And Register Process

This application is a simple sample application where login and registration processes are made.

During the registration process, the mail verification code sending feature was used.
 In addition, custom validations are used. Codefirst approach is adopted.
The "fromAddress" variable in the MailSender function in Mail.cs is the email address
(the sender's address, not the recipient's) to which the verification code sent by the server to the user during registration was sent.
The e-mail address written there must have less secure app access active. If it is not active, you can activate it from the link below.

https://myaccount.google.com/u/1/lesssecureapps?pli=1&rapt=AEjHL4PDjyxEUqExwoN71s40h0Gu4uA6AvMcfzLyAtcAjsP8xmgNcD_A42Vom6Ty26BuVDCpCkGR44ROGWOMPIa8

The body variable specifies the content of the message. The subject part specifies the subject. These variables can be customized as desired.

I would like to thank my friend Gokmen, who is the owner of the project and who made the interface.

I've included my and my friend's contact information below if you have any questions.

Gokmen NISANCI
GitHub:https://github.com/nisancigokmen
Mail:nisancigokmen@gmail.com

Batuhan BAYRAK
GitHub:https://github.com/Paramana16
Mail:bbayrakbbatuhan@outlook.com
