# wcf-membership-provider
Membership provider plugin using WCF connection instead of database.  100% compatible with .Net membership model

This project is a client/host solution that allows a client application to connect to a WCF host and provides all Membership and Role provider behavior.  There is no need to change any client code to move your membership & role behavior from direct database access to a WCF hosted proxy.

Hosting providers using WCF proxy provides several benefits including:
* Scalability - add/remove servers by simply referencing the authetication service WCF server
* Security - no need to include connection strings or database access in your DMZ servers
* Configuration management
* Works with local provider or remote provider by changing .config file.  No need for code change
