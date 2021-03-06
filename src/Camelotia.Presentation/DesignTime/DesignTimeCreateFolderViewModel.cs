using System.Windows.Input;
using Camelotia.Presentation.Interfaces;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.Validation.Helpers;

namespace Camelotia.Presentation.DesignTime
{
    public class DesignTimeCreateFolderViewModel : ReactiveValidationObject<DesignTimeCreateFolderViewModel>, ICreateFolderViewModel
    {
        public DesignTimeCreateFolderViewModel() => this.ValidationRule(x => x.Name, name => false, "Validation error.");
        
        public bool IsLoading { get; }

        public bool IsVisible { get; set; } = false;

        public string Name { get; set; }

        public string Path { get; } = "/home/path";

        public bool HasErrorMessage { get; } = true;

        public string ErrorMessage { get; } = "Error message example.";
        
        public ICommand Create { get; }
        
        public ICommand Close { get; }
        
        public ICommand Open { get; }
    }
}