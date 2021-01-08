using AppDev1.Objects;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static AppDev1.Objects.Project;

namespace AppDev1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LVPage : ContentPage
    {
        public ObservableCollection<Project> Items { get; set; }

        public LVPage()
        {
            InitializeComponent();

            var Apptext = "Mobile app development is the act or process by which a mobile app is developed for mobile devices, such as personal digital assistants, enterprise digital assistants or mobile phones. These applications can be pre-installed on phones during manufacturing platforms, or delivered as web applications using server-side or client-side processing (e.g., JavaScript) to provide an 'application - like' experience within a Web browser. Application software developers also must consider a long array of screen sizes, hardware specifications, and configurations because of intense competition in mobile software and changes within each of the platforms. Mobile app development has been steadily growing, in revenues and jobs created. A 2013 analyst report estimates there are 529,000 direct app economy jobs within the EU then 28 members (including the UK), 60 percent of which are mobile app developers. As part of the development process, mobile user interface (UI) design is also essential in the creation of mobile apps. Mobile UI considers constraints, contexts, screen, input, and mobility as outlines for design. The user is often the focus of interaction with their device, and the interface entails components of both hardware and software. User input allows for the users to manipulate a system, and device's output allows the system to indicate the effects of the users' manipulation. Mobile UI design constraints include limited attention and form factors, such as a mobile device's screen size for a user's hand(s). Mobile UI contexts signal cues from user activity, such as location and scheduling that can be shown from user interactions within a mobile app. Overall, mobile UI design's goal is mainly for an understandable, user-friendly interface. The UI of mobile apps should: consider users' limited attention, minimize keystrokes, and be task-oriented with a minimum set of functions. This functionality is supported by mobile enterprise application platforms or integrated development environments (IDEs).";
            var WebText = "Web development is the work involved in developing a Web site for the Internet (World Wide Web) or an intranet (a private network). Web development can range from developing a simple single static page of plain text to complex Web-based Internet applications (Web apps), electronic businesses, and social network services. A more comprehensive list of tasks to which Web development commonly refers, may include Web engineering, Web design, Web content development, client liaison, client-side/server-side scripting, Web server and network security configuration, and e-commerce development. Among Web professionals, 'Web development' usually refers to the main non-design aspects of building Web sites: writing markup and coding. Web development may use content management systems (CMS) to make content changes easier and available with basic technical skills. For larger organizations and businesses, Web development teams can consist of hundreds of people (Web developers) and follow standard methods like Agile methodologies while developing Web sites. Smaller organizations may only require a single permanent or contracting developer, or secondary assignment to related job positions such as a graphic designer or information systems technician. Web development may be a collaborative effort between departments rather than the domain of a designated department. There are three kinds of Web developer specialization: front-end developer, back-end developer, and full-stack developer. Front-end developers are responsible for behavior and visuals that run in the user browser, while back-end developers deal with the servers.";
            var NativeText = "According to IBM Research: 'Software development refers to a set of computer science activities dedicated to the process of creating, designing, deploying and supporting software.' Software itself is the set of instructions or programs that tell a computer what to do. It is independent of hardware and makes computers programmable. There are three basic types: System software to provide core functions such as operating systems, disk management, utilities, hardware management and other operational necessities. Programming software to give programmers tools such as text editors, compilers, linkers, debuggers and other tools to create code. Application software (applications or apps) to help users perform tasks. Office productivity suites, data management software, media players and security programs are examples. Applications also refers to web and mobile applications like those used to shop on Amazon.com, socialize with Facebook or post pictures to Instagram. A possible fourth type is embedded software. Embedded systems software is used to control machines and devices not typically considered computers — telecommunications networks, cars, industrial robots and more. These devices, and their software, can be connected as part of the Internet of Things (IoT).";
            var HardwareText = "Hardware development is usually more complex than software development for two main reasons: there are more steps you need to follow and you only have one opportunity to launch the right product. ﻿Bolt, a company that focuses on hardware startup investment, divided hardware development into four phases that simplify the process: ideation, design, engineering and validation. However, at Wikifactory we've taken it a step further, making the process more accessible by adding the concept and production phase. In this article, we will go through the different hardware development phases, starting with an idea and ending with a real product. Ideation phase: This phase is all about defining the need or opportunity and finding proof that the proposed solution works. For example, if you want to create a smart device that entertains your cat while you're home, you may want to test with lasers and feathers to see which one it prefers. You can move to the next step as soon as you clearly define your project and you have a potential solution. Concept phase: Once you have a potential solution, you need to optimise it and test different design assumptions. You need to make sure the product you have in mind will actually offer a solution that users are ready to adopt. A user-centric approach is useful in this phase because it guarantees that your product offers the solution the users are looking for. Invite users to test your product since the first prototype and constantly improve the experience. In this phase, you would need to define better how the device you have in mind would entertain the cat. How would the laser or feathers move? Is this a rugged device or a designer product? We refine the concept as much as we can in order to save time and resources during the next phases.";

            Random random = new Random();
            int i = 1;
            Items = new ObservableCollection<Project>
            {
                new Project(ProjectTypes.AppDevelopment, "Project" + i++, Apptext, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.WebDevelopment, "Project" + i++, WebText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.NativeAppDevelopment, "Project" + i++, NativeText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.HardwareDevelopment, "Project" + i++, HardwareText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.AppDevelopment, "Project" + i++, Apptext, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.WebDevelopment, "Project" + i++, WebText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.NativeAppDevelopment, "Project" + i++, NativeText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.HardwareDevelopment, "Project" + i++, HardwareText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.AppDevelopment, "Project" + i++, Apptext, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.WebDevelopment, "Project" + i++, WebText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.NativeAppDevelopment, "Project" + i++, NativeText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.HardwareDevelopment, "Project" + i++, HardwareText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.AppDevelopment, "Project" + i++, Apptext, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.WebDevelopment, "Project" + i++, WebText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.NativeAppDevelopment, "Project" + i++, NativeText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.HardwareDevelopment, "Project" + i++, HardwareText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.AppDevelopment, "Project" + i++, Apptext, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.WebDevelopment, "Project" + i++, WebText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.NativeAppDevelopment, "Project" + i++, NativeText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.HardwareDevelopment, "Project" + i++, HardwareText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.AppDevelopment, "Project" + i++, Apptext, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.WebDevelopment, "Project" + i++, WebText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.NativeAppDevelopment, "Project" + i++, NativeText, random.Next(0, 50).ToString()),
                new Project(ProjectTypes.HardwareDevelopment, "Project" + i++, HardwareText, random.Next(0, 50).ToString())
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;


            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        async void ToDescription(object sender, EventArgs e)
        {
            Button button = sender as Button;
            await Navigation.PushAsync(new DescriptionPage(button.BindingContext as Project));
        }
    }
}
