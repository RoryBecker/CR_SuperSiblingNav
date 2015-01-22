using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_SuperSiblingNav
{
  [Export(typeof(IVsixPluginExtension))]
  public class CR_SuperSiblingNavExtension : IVsixPluginExtension { }
}