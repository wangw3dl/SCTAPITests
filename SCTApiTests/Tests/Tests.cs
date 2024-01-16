using NUnit.Framework;
using System.Threading.Tasks;

namespace SCTApiTestProject.Tests
{
    [TestFixture]
    public class Tests
    {
        private CategoryDetails? categoryDetails; // Declare as nullable

        [SetUp]
        public async Task TestSetUp()
        {
            // Initialize in the SetUp method using the static method from the TestSetup class
            categoryDetails = await Task.Run(() => TestSetup.InitializeCategoryDetails());
        }

        [Test]
        public void NameShouldBe()
        {
            string expectedName = "Carbon credits";
            // Assert the name should be "Carbon credits”. 
            Assert.AreEqual(expectedName, categoryDetails?.Name, "Name is not as expected.");
        }

        [Test]
        public void CanRelistShouldBeTrue()
        {
            // Assert CanRelist should be set to true.
            Assert.IsTrue(categoryDetails?.CanRelist ?? false, "CanRelist should be true.");
        }

        [Test]
        public void GalleryPromotionDescriptionShouldContain()
        {
            string expectedText = "Good position in category";
            var promotions = categoryDetails?.Promotions;
            var galleryPromotion = promotions != null ? Array.Find(promotions, p => p.Name == "Gallery") : null;

            // Assert the Promotions element with Name = "Gallery" has a Description that contains the text "Good position in category"
            StringAssert.Contains(expectedText, galleryPromotion?.Description,
                "Gallery promotion description does not contain expected text.");
        }
    }
}