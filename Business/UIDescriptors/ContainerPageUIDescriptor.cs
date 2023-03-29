using EPiServer.Shell;
using CMS12.Alloy.Models.Pages;

namespace CMS12.Alloy.Business.UIDescriptors;

/// <summary>
/// Describes how the UI should appear for <see cref="ContainerPage"/> content.
/// </summary>
[UIDescriptorRegistration]
public class ContainerPageUIDescriptor : UIDescriptor<ContainerPage>
{
    public ContainerPageUIDescriptor()
        : base(ContentTypeCssClassNames.Container)
    {
        DefaultView = CmsViewNames.AllPropertiesView;
    }
}
