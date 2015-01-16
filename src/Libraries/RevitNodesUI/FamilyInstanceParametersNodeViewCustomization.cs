﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSCoreNodesUI;
using Dynamo.Wpf;
using Dynamo.Wpf.Nodes;
using DSRevitNodesUI;

namespace Dynamo.Wpf.Nodes.Revit
{
    public class FamilyInstanceParametersNodeViewCustomization : DropDownNodeViewCustomization, INodeViewCustomization<FamilyInstanceParameters>
    {
        public void CustomizeView(FamilyInstanceParameters model, Dynamo.Controls.NodeView nodeView)
        {
            base.CustomizeView(model, nodeView);
            
            // this is not a recommended workaround
            model.EngineController = nodeView.ViewModel.DynamoViewModel.EngineController;
        }
    }
}
