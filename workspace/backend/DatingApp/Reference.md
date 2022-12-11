```mermaid
graph TD;
   Dating.Api --> Dating.Core
   Dating.Api --> Dating.UI
   Dating.Api --> Dating.Config
   Dating.Db --> Dating.Config
   Dating.Core --> Dating.Db
   Dating.Core --> Dating.UI
```