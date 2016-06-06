using System.Web.Mvc;
using NUnit.Framework;
using SpecsFor;
using Should;
using GIMS.Web.Controllers;


namespace GIMS.Specs.GIMS.Web.Controllers
{
    public class HomeControllerSpecs
    {

        public class when_viewing_index_action : SpecsFor<HomeController>
        {
            private ActionResult _result;

            protected override void Given()
            {
                ////GetMockFor<HomeController>()
                ////    .Setup(x => x)
                ////    .Returns( new HomeController());

                //var mockHomeController = GetMockFor<HomeController>();
                //mockHomeController.Setup(x => x.Username).Returns("cha");
            }

            protected override void When()
            {
                _result = SUT.Index();
            }

            [Test]
            public void then_it_retuns_a_view_result()
            {
                _result.ShouldBeType<ViewResult>();
            }

            //[Test]
            //public void then_it_retuns_username()
            //{

            //    string username = ((ViewResult) _result).ViewBag.Username;

            //    username.ShouldEqual("Cha");
            //}
        }

        public class when_saying_hello_to_a_user : SpecsFor<HomeController>
        {
            private ActionResult _result;

            protected override void When()
            {
                _result = SUT.SayHello("John Doe");
            }

            [Test]
            public void then_it_says_hello_to_the_user()
            {
                Assert.That(_result, Is.TypeOf<ViewResult>());
                Assert.That(((ViewResult)_result).Model, Is.TypeOf<SayHelloViewModel>());
                Assert.That(((SayHelloViewModel)((ViewResult)_result).Model).Name, Is.EqualTo("John Doe"));

                //_result.ShouldRenderDefaultView()
                //    .WithModelLike(new SayHelloViewModel
                //    {
                //        Name = "John Doe"
                //    });
            }
        }

        public class when_saying_hello_with_a_form : SpecsFor<HomeController>
        {
            private ActionResult _result;

            protected override void When()
            {
                _result = SUT.SayHello(new SayHelloForm { Name = "Jane Doe" });
            }

            [Test]
            public void then_it_redirects_to_the_say_hello_action()
            {
                //_result.ShouldRedirectTo<HomeController>(
                //    c => c.SayHello("Jane Doe"));

                var routeResult = (RedirectToRouteResult)_result;
                Assert.That(routeResult.RouteValues["action"], Is.EqualTo("SayHello"));
                Assert.That(routeResult.RouteValues["name"], Is.EqualTo("Jane Doe"));

            }
        }

    }
}

//public class when_viewing_index_action : SpecsFor<HomeController>
//{
//    private ActionResult _result;

//    protected override void Given()
//    {
//        GetMockFor<ICurrentUser>()
//            .Setup(x => x.UserName)
//            .Returns("John Doe");
//    }

//    protected override void When()
//    {
//        _result = SUT.Index();
//    }

//    [Test]
//    public void then_it_returns_a_view_result()
//    {
//        _result.ShouldBeType<ViewResult>();
//    }

//    [Test]
//    public void then_it_says_hello_to_the_viewer()
//    {
//        string message =
//            ((ViewResult)_result).ViewBag.Message;

//        message.ShouldEqual("Hello, John Doe!");
//    }
//}

//public class when_setting_the_users_name : SpecsFor<HomeController>
//{
//    private ActionResult _result;

//    protected override void When()
//    {
//        _result = SUT.SetName("Jane Doe");
//    }

//    [Test]
//    public void then_it_sets_the_name_of_the_user()
//    {
//        GetMockFor<ICurrentUser>()
//            .Verify(x => x.SetName("Jane Doe"));
//    }

//    [Test]
//    public void then_it_redirects_back_home()
//    {
//        var routeResult = (RedirectToRouteResult)_result;
//        routeResult.RouteValues["action"].ShouldEqual("Index");
//    }
//}

//public class when_saying_hello_to_a_user : SpecsFor<HomeController>
//{
//    private ActionResult _result;

//    protected override void When()
//    {
//        _result = SUT.SayHello("John Doe");
//    }

//    [Test]
//    public void then_it_says_hello_to_the_user()
//    {
//        _result.ShouldRenderDefaultView()
//            .WithModelLike(new SayHelloViewModel
//            {
//                Name = "John Doe"
//            });
//    }
//}

//public class when_saying_hello_with_a_form : SpecsFor<HomeController>
//{
//    private ActionResult _result;

//    protected override void When()
//    {
//        _result = SUT.SayHello(new SayHelloForm { Name = "Jane Doe" });
//    }

//    [Test]
//    public void then_it_redirects_to_the_say_hello_action()
//    {
//        _result.ShouldRedirectTo<HomeController>(
//            c => c.SayHello("Jane Doe"));
//    }
//}



