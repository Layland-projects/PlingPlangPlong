using NUnit.Framework;
using PlingPlangPlong;

namespace PlingPlangPlong.Tests
{
    public class PlingPlangPlong_Static_Tests
    {
        [TestCase(-3)]
        [TestCase(6)]
        [TestCase(-9)]
        [TestCase(12)]
        [TestCase(-18)]
        [TestCase(24)]
        public void GivenIHaveANumerThatOnlyHasAFactorOf3_WhenIPassItToPlingPlangPlong_Static_ThenItShouldReturnPling(int val)
        {
            Assert.That(PlingPlangPlong_Static.PlingPlangPlong(val), Is.EqualTo("Pling"));
        }

        [TestCase(-5)]
        [TestCase(10)]
        [TestCase(-20)]
        [TestCase(25)]
        [TestCase(-40)]
        [TestCase(50)]
        public void GivenIHaveANumerThatOnlyHasAFactorOf5_WhenIPassItToPlingPlangPlong_Static_ThenItShouldReturnPlang(int val)
        {
            Assert.That(PlingPlangPlong_Static.PlingPlangPlong(val), Is.EqualTo("Plang"));
        }

        [TestCase(-7)]
        [TestCase(14)]
        [TestCase(-28)]
        [TestCase(49)]
        [TestCase(-56)]
        [TestCase(91)]
        public void GivenIHaveANumerThatOnlyHasAFactorOf7_WhenIPassItToPlingPlangPlong_Static_ThenItShouldReturnPlong(int val)
        {
            Assert.That(PlingPlangPlong_Static.PlingPlangPlong(val), Is.EqualTo("Plong"));
        }

        [TestCase(-2)]
        [TestCase(4)]
        [TestCase(-8)]
        [TestCase(16)]
        [TestCase(-22)]
        [TestCase(26)]
        public void GivenIHaveANumerThatDoesNotHaveAFactorOf3Or5Or7_WhenIPassItToPlingPlangPlong_Static_ThenItShouldReturnTheStringEquivalentOfTheInput(int val)
        {
            Assert.That(PlingPlangPlong_Static.PlingPlangPlong(val), Is.EqualTo(val.ToString()));
        }

        [TestCase(-15)]
        [TestCase(30)]
        [TestCase(-45)]
        [TestCase(60)]
        [TestCase(-75)]
        [TestCase(90)]
        public void GivenIHaveANumerThatHasAFactorOf3And5_WhenIPassItToPlingPlangPlong_Static_ThenItShouldReturnPlingPlang(int val)
        {
            Assert.That(PlingPlangPlong_Static.PlingPlangPlong(val), Is.EqualTo("PlingPlang"));
        }

        [TestCase(-35)]
        [TestCase(70)]
        [TestCase(-140)]
        [TestCase(175)]
        [TestCase(-245)]
        [TestCase(280)]
        public void GivenIHaveANumerThatHasAFactorOf5And7_WhenIPassItToPlingPlangPlong_Static_ThenItShouldReturnPlangPlong(int val)
        {
            Assert.That(PlingPlangPlong_Static.PlingPlangPlong(val), Is.EqualTo("PlangPlong"));
        }

        [TestCase(0)]
        [TestCase(-105)]
        [TestCase(210)]
        [TestCase(-315)]
        [TestCase(420)]
        [TestCase(-525)]
        public void GivenIHaveANumerThatHasAFactorOf3And5And7_WhenIPassItToPlingPlangPlong_Static_ThenItShouldReturnPlingPlangPlong(int val)
        {
            Assert.That(PlingPlangPlong_Static.PlingPlangPlong(val), Is.EqualTo("PlingPlangPlong"));
        }
    }
}