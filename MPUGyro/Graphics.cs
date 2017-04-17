using MPUGyro.Models;
using System;


namespace MPUGyro
{
    public class Graphics
    {
        private readonly IMpuGyro _view;
        public Graphics(IMpuGyro view)
        {
            _view = view;
        }
        public void DrowGraphics(KrenModel model)
        {
            _view.Chart0_Kren.ChartAreas[0].AxisX.ScaleView.Zoom(0, 100);
            _view.Chart0_Kren.ChartAreas[0].CursorX.IsUserEnabled = true;
            _view.Chart0_Kren.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            _view.Chart0_Kren.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            _view.Chart0_Kren.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            _view.Chart0_Kren.ChartAreas[0].AxisY.ScaleView.Zoom(-1, 1);
            _view.Chart0_Kren.ChartAreas[0].CursorY.IsUserEnabled = true;
            _view.Chart0_Kren.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            _view.Chart0_Kren.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            _view.Chart0_Kren.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            for (int i = 0; i < model.Times.Count - 1; i++)
            {
                _view.Chart0_Kren.Series[0].Points.AddXY(model.Times[i], model.KrenX[i]);
            }
            for (int i = 0; i < model.Times.Count - 1; i++)
            {
                _view.Chart0_Kren.Series[1].Points.AddXY(model.Times[i], model.KrenY[i]);
            }
            for (int i = 0; i < model.Times.Count - 1; i++)
            {
                _view.Chart0_Kren.Series[2].Points.AddXY(model.Times[i], model.KrenZ[i]);
            }
        }
    }
}
