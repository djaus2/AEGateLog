# AEGateLog
Because of COVID-19 we have to log all entries to our Athletics Track. This is a QR Code based Blazor WebAssembly app. 

Works now
- Data is sent to Azure SQL
- Not all pages show on sidebar.
  - Want users to accept before getting to log page
  - Admin login (Mangement) wil also be similarly hidden, nota t the moment though.
  - Magic numbers are in the path for these pages which is checked.
    - A daily pin number is also used for some pages.
 - FetchData page
   - Only in admin mode
   - Now has Calendar
   - Can delete logs older than 28 days
- Pseudo Admin mode.
  - Login from Management tab
    - Add /Management/137 to base Url to access
    - Also QRCode page: Add /qrcode to base URl
  - App then enables the QR Code page and FetchData page.
  - Logout on FetchData page.
  - Login and out may need the page to be refreshed.
  - Also; Once Admined in if go to non Admin page you are logged out.
- Added GPS capability to log where log occurs
