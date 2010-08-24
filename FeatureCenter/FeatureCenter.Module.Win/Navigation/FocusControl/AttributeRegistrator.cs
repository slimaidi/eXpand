﻿using System;
using System.Collections.Generic;
using DevExpress.ExpressApp.DC;
using eXpand.ExpressApp.AdditionalViewControlsProvider.Logic;
using eXpand.ExpressApp.Attributes;

namespace FeatureCenter.Module.Win.Navigation.FocusControl
{
    public class AttributeRegistrator : Module.AttributeRegistrator
    {
        public override IEnumerable<Attribute> GetAttributes(ITypeInfo typesInfo) {
            if (typesInfo.Type!=typeof(WinCustomer))yield break;
            yield return new AdditionalViewControlsRuleAttribute(Module.Captions.ViewMessage + " " + Captions.HeaderFocusControl, "1=1", "1=1",
                Captions.ViewMessageFocusControl, Position.Bottom){View = "FocusControl_DetailView"};
            yield return new AdditionalViewControlsRuleAttribute(Module.Captions.Header + " " + Captions.HeaderFocusControl, "1=1", "1=1",
                Captions.HeaderFocusControl, Position.Top){View = "FocusControl_DetailView"};
            yield return new CloneViewAttribute(CloneViewType.DetailView, "FocusControl_DetailView");
            yield return new NavigationItemAttribute("Navigation/Focus Control", "FocusControl_DetailView");
            yield return new DisplayFeatureModelAttribute("FocusControl_DetailView");
        }
    }
}