<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryCatchFail.LearnStructureMap.Lesson3.WebForms._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Page.Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            <p>
                <asp:Label runat="server" ID="lblWelcomeMessage"></asp:Label>
            </p>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>We suggest the following:</h3>

    <ol class="round">
        <li class="one">
            <h5>Configure ASP.NET Membership</h5>
            ASP.NET membership gives you a built-in way to create, store, and 
            validate user credentials (authentication). By default, membership works with a local instance of SQL Server, 
            but you can configure it to use another database.
        </li>
        <li class="two">
            <h5>Add NuGet packages and jump start your coding</h5>
            NuGet makes it easy to install and update free libraries and tools in Visual Studio. In <em>Solution Explorer</em>, 
            right-click the <em>References</em> node, select <em>Manage NuGet Packages</em>, and then pick from the extensive 
            list of packages.
        </li>
        <li class="three">
            <h5>Setup deployment to your web server</h5>
            Use Microsoft Web Deploy to quickly and easily publish your application to a web server. 
            In <em>Solution Explorer</em>, right-click your project, select <em>Publish</em>, 
            and choose one of the many options to get your code deployed and running on the web.
        </li>
    </ol>

    <section class="features">
        <section class="feature">
            <img runat="server" src="~/Images/aspNetHome.png" alt="" />
            <h3>Home of ASP.NET</h3>
            <p>
                ASP.NET is a free, fully supported Web application framework that helps you create standards-based web solutions. 
                Whether you're new to ASP.NET or an experienced developer, the <a href="http://asp.net">ASP.NET website</a> 
                is your source for news, training, downloads, and support. 
            </p>
        </section>
        <section class="feature">
            <img runat="server" src="~/Images/NuGetGallery.png" alt="" />
            <h3>NuGet Gallery</h3>
            <p>
                NuGet is a Visual Studio extension that makes it easy to install and update open source libraries and tools in 
                Visual Studio. To see available packages, visit the <a href="http://nuget.org">NuGet gallery</a>.
                You can also develop your own package and share it in the gallery.
            </p>
        </section>
        <section class="feature">
            <img runat="server" src="~/Images/findHosting.png" alt="" />
            <h3>Find Web Hosting</h3>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications. 
                Visit <a href="http://microsoft.com/web/hosting" title="Microsoft/Web Website">Microsoft.com/web</a> to 
                explore offerings from many providers.
            </p>
        </section>
    </section>
</asp:Content>