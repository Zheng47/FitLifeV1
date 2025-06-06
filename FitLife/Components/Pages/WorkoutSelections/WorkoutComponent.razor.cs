﻿using FitLife.Models.Exercises;
using Microsoft.AspNetCore.Components;

namespace FitLife.Components.Pages.WorkoutSelections;

public partial class WorkoutComponent
{
    [Parameter]
    public Exercise Exercise { get; set; } = default!;

    [Parameter]
    public EventCallback<Exercise> Delegate { get; set; }

    public bool CheckDelegateIfExists()
    {
        return Delegate.HasDelegate;
    }

    public async Task RunButton()
    {
        if(CheckDelegateIfExists())
        {
            await Delegate.InvokeAsync(Exercise);
        }
    }

}
