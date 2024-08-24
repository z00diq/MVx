using Assets._Project.Scripts.MVP.Presenters;
using Assets._Project.Scripts.MVVM;
using UnityEngine;
using UnityEngine.UI;
using SimpleModel = Assets._Project.Scripts.Models.SimpleModel;
using View = Assets._Project.Scripts.Views.View;
using MVVMSimpleModel = Assets._Project.Scripts.MVVM.SimpleModel;
using MVVMView = Assets._Project.Scripts.MVVM.View;
using static UnityEditor.Profiling.HierarchyFrameDataView;

namespace Assets._Project.Scripts
{
    public class Game: MonoBehaviour
    {
        [Header("MVC")]
        [SerializeField] private View _view;
        [SerializeField] private Button _plus;
        [SerializeField] private Button _minus;
        [SerializeField] private InputField _input;
        
        [Header("MVP")]
        [SerializeField] private MVP.Views.View _mvpView;

        [Header("MVVM")]
        [SerializeField] private MVVMView _mvvmView;
        


        private void Awake()
        {
            SimpleModel model = new SimpleModel(_view);
            SimpleController simpleController = new SimpleController(_view, model);

            _plus.onClick.AddListener(simpleController.IncrementintValue);
            _minus.onClick.AddListener(simpleController.DecrementintValue);
            _input.onValueChanged.AddListener(simpleController.ChangeString);

            MVP.Models.SimpleModel MVPModel = new MVP.Models.SimpleModel(_mvpView);
            SimplePresenter simplePresenter = new SimplePresenter(MVPModel);
            _mvpView.Constrtuct(simplePresenter);

            MVVMSimpleModel MVVMsimpleModel = new MVVMSimpleModel();
            SimpleViewModel viewModel = new SimpleViewModel(MVVMsimpleModel);
            _mvvmView.Construct(viewModel);
            viewModel.Initialize();
        }

        private void OnDestroy()
        {
            _plus.onClick.RemoveAllListeners();
            _minus.onClick.RemoveAllListeners();
            _input.onValueChanged.RemoveAllListeners();
        }
    }
}
