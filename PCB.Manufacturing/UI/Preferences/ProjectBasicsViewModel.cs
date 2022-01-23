using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PCB.Manufacturing.Model;
using Prism.Mvvm;

namespace PCB.Manufacturing.UI.Preferences;

public sealed class ProjectBasicsViewModel : BindableBase, IDataErrorInfo
{
    private readonly Dictionary<string, string?> _errors = new();

    private readonly ProjectInfo _projectInfo;

    private readonly ValidatedQuantity _validatedQuantity = new();

    private readonly ValidatedZipcode _validatedZipcode = new();

    private string _boardsQuantity;

    private string _zipcode;

    public ProjectBasicsViewModel(ProjectInfo projectInfo)
    {
        _projectInfo = projectInfo;
    }

    public string BoardsQuantity
    {
        get => _boardsQuantity;
        set
        {
            var validationResult = _validatedQuantity.Check(value);

            if (validationResult == ValidatedQuantity.QuantityValidationResult.Valid)
            {
                _projectInfo.BoardsQuantity = int.Parse(value);
                _dataError(null);
            }
            else
            {
                _dataError(ValidatedQuantity.ValidationMessages[validationResult]);
            }

            SetProperty(ref _boardsQuantity, value);
        }
    }

    public string? this[string columnName]
    {
        get
        {
            _errors.TryGetValue(columnName, out var error);
            return error;
        }
    }

    public string ProjectName
    {
        get => _projectInfo.ProjectName;
        set => SetProperty(ref _projectInfo.ProjectName, value);
    }

    public string Zipcode
    {
        get => _zipcode;
        set
        {
            var validationResult = _validatedZipcode.Check(value);
            if (validationResult == ValidatedZipcode.ZipcodeValidationResult.Valid)
            {
                _projectInfo.Zipcode = value;
                _dataError(null);
            }
            else
            {
                _dataError(ValidatedZipcode.ValidationMessages[validationResult]);
            }

            SetProperty(ref _zipcode, value);
        }
    }

    string IDataErrorInfo.Error => throw new NotImplementedException();

    private void _dataError(string? error, [CallerMemberName] string propertyName = "")
    {
        _errors[propertyName] = error;
    }
}