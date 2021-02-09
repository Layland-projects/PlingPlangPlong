using NUnit.Framework;
using PlingPlangPlong;

namespace PlingPlangPlong_Tests
{
    public class Tests
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(18)]
        [TestCase(24)]
        public void GivenIHaveANumerThatOnlyHasAFactorOf3_WhenIConstructMyObject_ThenTheResultShouldBePling(int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo("Pling"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        [TestCase(40)]
        [TestCase(50)]
        public void GivenIHaveANumerThatOnlyHasAFactorOf5_WhenIConstructMyObject_ThenTheResultShouldBePlang(int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo("Plang"));
        }

        [TestCase(7)]
        [TestCase(14)]
        [TestCase(28)]
        [TestCase(49)]
        [TestCase(56)]
        [TestCase(91)]
        public void GivenIHaveANumerThatOnlyHasAFactorOf7_WhenIConstructMyObject_ThenTheResultShouldBePlong(int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo("Plong"));
        }

        [TestCase(2)]
        [TestCase(4)]
        [TestCase(8)]
        [TestCase(16)]
        [TestCase(22)]
        [TestCase(26)]
        public void GivenIHaveANumerThatDoesNotHaveAFactorOf3Or5Or7_WhenIConstructMyObject_ThenTheResultShouldBeTheStringEquivalentOfTheInput(int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo(val.ToString()));
        }
    }
}