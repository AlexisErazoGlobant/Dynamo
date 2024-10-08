using System.Windows;
using System.Windows.Controls;
using Dynamo.Controls;
using Dynamo.Graph.Nodes;
using Dynamo.Nodes;
using Dynamo.UI;

namespace Dynamo.Wpf
{
    public class VariableInputNodeViewCustomization : INodeViewCustomization<VariableInputNode>
    {
        public virtual void CustomizeView(VariableInputNode nodeModel, NodeView nodeView)
        {
            var addButton = new DynamoNodeButton(nodeView.ViewModel.NodeModel, "AddInPort")
            {
                Content = "+",
                Style = (Style)SharedDictionaryManager.DynamoModernDictionary["AddRemoveButton"]
            };

            var subButton = new DynamoNodeButton(nodeView.ViewModel.NodeModel, "RemoveInPort")
            {
                Content = "-",
                Style = (Style)SharedDictionaryManager.DynamoModernDictionary["AddRemoveButton"]
            };

            var wp = new WrapPanel
            {
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Center
            };

            wp.Children.Add(addButton);
            wp.Children.Add(subButton);

            nodeView.inputGrid.Children.Add(wp);
        }

        public void Dispose()
        {

        }
    }
}