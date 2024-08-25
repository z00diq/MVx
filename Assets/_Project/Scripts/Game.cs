using Assets._Project.Scripts.MVP;
using Assets._Project.Scripts.MVC;
using Assets._Project.Scripts.MVVM;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts
{
    public class Game: MonoBehaviour
    {
        [Header("MVC")]
        [SerializeField] private MVCView _view;
        [SerializeField] private Button _plus;
        [SerializeField] private Button _minus;
        [SerializeField] private InputField _input;
        
        [Header("MVP")]
        [SerializeField] private MVPView _mvpView;

        [Header("MVVM")]
        [SerializeField] private MVVMView _mvvmView;
        


        private void Awake()
        {
            MVCModel model = new MVCModel(_view);
            MVCController simpleController = new MVCController(_view, model);

            _plus.onClick.AddListener(simpleController.IncrementintValue);
            _minus.onClick.AddListener(simpleController.DecrementintValue);
            _input.onValueChanged.AddListener(simpleController.ChangeString);

            MVPModel MVPModel = new MVPModel(_mvpView);
            MVPPresenter simplePresenter = new MVPPresenter(MVPModel);
            _mvpView.Constrtuct(simplePresenter);

            MVVMModel MVVMsimpleModel = new MVVMModel();
            MVVMViewModel viewModel = new MVVMViewModel(MVVMsimpleModel);
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
