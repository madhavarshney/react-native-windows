﻿using Facebook.CSSLayout;
using ReactNative.UIManager;

namespace ReactNative.Views.Slider
{
    /// <summary>
    /// The shadow node implementation for Slider views.
    /// </summary>
    public class ReactSliderShadowNode : LayoutShadowNode
    {
        /// <summary>
        /// Instantiates the <see cref="ReactSliderShadowNode"/>.
        /// </summary>
        public ReactSliderShadowNode()
        {
            SetMeasureFunction(MeasurePicker);
        }

        private static void MeasurePicker(CSSNode node, float width, CSSMeasureMode widthMode, float height, CSSMeasureMode heightMode, MeasureOutput output)
        {
            output.Width = width;
            output.Height = 40;
        }
    }
}
