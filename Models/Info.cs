namespace mobile_shop_core_.Models
{
    public class Info
    {

        //////// for programe.cs

        //app.UseEndpoints(endpoints =>
        //{
        //    // Admin Area Routing
        //    endpoints.MapAreaControllerRoute(
        //        name: "Admin",
        //        areaName: "Admin",
        //        pattern: "Admin/{controller=Admin}/{action=Dashboard}/{id?}"
        //    );

        //    // User Area Routing
        //    endpoints.MapAreaControllerRoute(
        //        name: "User",
        //        areaName: "User",
        //        pattern: "User/{controller=Shop}/{action=Index}/{id?}"
        //    );

        //    // Default Route (Home)
        //    endpoints.MapControllerRoute(
        //        name: "default",
        //        pattern: "{controller=Home}/{action=Index}/{id?}"
        //    );
        //});



        ////// For Pathhh



        //📌 Explanation of Paths & Routing
        //1️⃣ Admin Panel (Areas/Admin)
        //📂 Path: Areas / Admin / Controllers / AdminController.cs
        //📂 Views Path: Areas / Admin / Views / Admin / Dashboard.cshtml
        //📂 Shared Layout Path: Areas / Admin / Views / Shared / _AdminLayout.cshtml

        //📌 Example Routes

        //Functionality	Path (URL)
        //Admin Dashboard	/Admin/Admin/Dashboard
        //Manage Products	/Admin/Products/Index
        //Manage Orders	/Admin/Orders/Index
        //Manage Users	/Admin/Users/Index
        //2️⃣ User Panel (Areas/User)
        //📂 Path: Areas / User / Controllers / ShopController.cs
        //📂 Views Path: Areas / User / Views / Shop / Index.cshtml
        //📂 Shared Layout Path: Areas / User / Views / Shared / _UserLayout.cshtml

        //📌 Example Routes

        //Functionality	Path (URL)
        //View Products	/User/Shop/Index
        //View Cart	/User/Cart/Index
        //Login Page	/User/Account/Login
        //Register Page	/User/Account/Register
        //3️⃣ Home Panel (Controllers/HomeController.cs)
        //📂 Path: Controllers / HomeController.cs
        //📂 Views Path: Views / Home / Index.cshtml
        //📂 Shared Layout Path: Views / Shared / _Layout.cshtml

        //📌 Example Routes

        //Functionality	Path (URL)
        //Home Page	/Home/Index or /
        //About Page	/Home/About
        //Contact Page	/Home/Contact










        // structure

        //📂 MobileShop
        //│── 📂 Areas
        //│   ├── 📂 Admin
        //│   │   ├── 📂 Controllers
        //│   │   │   ├── AdminController.cs
        //│   │   │   ├── ProductsController.cs
        //│   │   │   ├── OrdersController.cs
        //│   │   │   ├── UsersController.cs
        //│   │   │   ├── RechargePlansController.cs
        //│   │   ├── 📂 Views
        //│   │   │   ├── 📂 Admin
        //│   │   │   │   ├── Dashboard.cshtml
        //│   │   │   ├── 📂 Shared
        //│   │   │   │   ├── _AdminLayout.cshtml
        //│
        //│── 📂 Areas
        //│   ├── 📂 User
        //│   │   ├── 📂 Controllers
        //│   │   │   ├── ShopController.cs
        //│   │   │   ├── CartController.cs
        //│   │   │   ├── AccountController.cs
        //│   │   ├── 📂 Views
        //│   │   │   ├── 📂 Shop
        //│   │   │   │   ├── Index.cshtml
        //│   │   │   ├── 📂 Cart
        //│   │   │   │   ├── Index.cshtml
        //│   │   │   ├── 📂 Account
        //│   │   │   │   ├── Login.cshtml
        //│   │   │   │   ├── Register.cshtml
        //│   │   │   ├── 📂 Shared
        //│   │   │   │   ├── _UserLayout.cshtml
        //│
        //│── 📂 Controllers
        //│   ├── HomeController.cs
        //│
        //│── 📂 Views
        //│   ├── 📂 Home
        //│   │   ├── Index.cshtml
        //│   │   ├── About.cshtml
        //│   │   ├── Contact.cshtml
        //│   ├── 📂 Shared
        //│   │   ├── _Layout.cshtml
        //│
        //│── 📂 Models
        //│── 📂 Data
        //│── 📂 wwwroot
        //│── appsettings.json
        //│── Program.cs
        //│── Startup.cs


    }
}
