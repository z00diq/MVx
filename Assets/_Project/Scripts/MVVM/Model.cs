namespace Assets._Project.Scripts.MVVM
{
    public abstract class Model
    {
        public readonly ReactiveProperty<int> IntValue = new();
        public readonly ReactiveProperty<string> StringValue = new();
    }
}
