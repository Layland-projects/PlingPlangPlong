using NUnit.Framework;
using PlingPlangPlong;

namespace PlingPlangPlong_Tests
{
    public class Tests
    {
        [TestCase(-3)]
        [TestCase(6)]
        [TestCase(-9)]
        [TestCase(12)]
        [TestCase(-18)]
        [TestCase(24)]
        public void GivenIHaveANumerThatOnlyHasAFactorOf3_WhenIConstructMyObject_ThenTheResultShouldBePling(int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo("Pling"));
        }

        [TestCase(-5)]
        [TestCase(10)]
        [TestCase(-20)]
        [TestCase(25)]
        [TestCase(-40)]
        [TestCase(50)]
        public void GivenIHaveANumerThatOnlyHasAFactorOf5_WhenIConstructMyObject_ThenTheResultShouldBePlang(int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo("Plang"));
        }

        [TestCase(-7)]
        [TestCase(14)]
        [TestCase(-28)]
        [TestCase(49)]
        [TestCase(-56)]
        [TestCase(91)]
        public void GivenIHaveANumerThatOnlyHasAFactorOf7_WhenIConstructMyObject_ThenTheResultShouldBePlong(int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo("Plong"));
        }

        [TestCase(-2)]
        [TestCase(4)]
        [TestCase(-8)]
        [TestCase(16)]
        [TestCase(-22)]
        [TestCase(26)]
        public void GivenIHaveANumerThatDoesNotHaveAFactorOf3Or5Or7_WhenIConstructMyObject_ThenTheResultShouldBeTheStringEquivalentOfTheInput(int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo(val.ToString()));
        }

        [TestCase(-15)]
        [TestCase(30)]
        [TestCase(-45)]
        [TestCase(60)]
        [TestCase(-75)]
        [TestCase(90)]
        public void GivenIHaveANumerThatHasAFactorOf3And5_WhenIConstructMyObject_ThenTheResultShouldBePlingPlang (int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo("PlingPlang"));
        }

        [TestCase(-35)]
        [TestCase(70)]
        [TestCase(-140)]
        [TestCase(175)]
        [TestCase(-245)]
        [TestCase(280)]
        public void GivenIHaveANumerThatHasAFactorOf5And7_WhenIConstructMyObject_ThenTheResultShouldBePlangPlong(int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo("PlangPlong"));
        }

        [TestCase(0)]
        [TestCase(-105)]
        [TestCase(210)]
        [TestCase(-315)]
        [TestCase(420)]
        [TestCase(-525)]
        public void GivenIHaveANumerThatHasAFactorOf3And5And7_WhenIConstructMyObject_ThenTheResultShouldBePlingPlangPlong(int val)
        {
            var sut = new PlingPlangPlong_Object(val);

            Assert.That(sut.Result, Is.EqualTo("PlingPlangPlong"));
        }
    }
}