using NUnit.Framework;

namespace FluentNHibernate.Testing.FluentInterfaceTests
{
    [TestFixture]
    public class VersionMutablePropertyModelGenerationTests : BaseModelFixture
    {
        [Test]
        public void AccessShouldSetModelAccessPropertyToValue()
        {
            Version()
                .Mapping(m => m.Access.AsField())
                .ModelShouldMatch(x => x.Access.ShouldEqual("field"));
        }

        [Test]
        public void ColumnNameShouldSetModelColumnPropertyToValue()
        {
            Version()
                .Mapping(m => m.ColumnName("col"))
                .ModelShouldMatch(x => x.Column.ShouldEqual("col"));
        }

        [Test]
        public void GeneratedShouldSetModelGeneratedPropertyToValue()
        {
            Version()
                .Mapping(m => m.Generated.Always())
                .ModelShouldMatch(x => x.Generated.ShouldEqual("always"));
        }

        [Test]
        public void ShouldSetModelNamePropertyToPropertyName()
        {
            Version()
                .Mapping(m => { })
                .ModelShouldMatch(x => x.Name.ShouldEqual("VersionNumber")); // set in Version(), bad form I know
        }

        [Test]
        public void ShouldSetModelTypePropertyToPropertyType()
        {
            Version()
                .Mapping(m => { })
                .ModelShouldMatch(x => x.Type.ShouldEqual(typeof(int).AssemblyQualifiedName));
        }

        [Test]
        public void UnsavedValueShouldSetModelTypeUnsavedValueToValue()
        {
            Version()
                .Mapping(m => m.UnsavedValue("any"))
                .ModelShouldMatch(x => x.UnsavedValue.ShouldEqual("any"));
        }
    }
}