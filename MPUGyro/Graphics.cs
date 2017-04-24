using MPUGyro.Models;

namespace MPUGyro
{
    public class Graphics
    {
        private readonly IMpuGyro _view;

        public Graphics()
        {
        }

        public Graphics(IMpuGyro view)
        {
            _view = view;
        }
        public void DrowGraphics(OrtogSensor model)
        {
            _view.Chart0_Kren.ChartAreas[0].AxisX.ScaleView.Zoom(0, 120);
            _view.Chart0_Kren.ChartAreas[0].CursorX.IsUserEnabled = true;
            _view.Chart0_Kren.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            _view.Chart0_Kren.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            _view.Chart0_Kren.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            _view.Chart0_Kren.ChartAreas[0].AxisY.ScaleView.Zoom(-90, 90);
            _view.Chart0_Kren.ChartAreas[0].CursorY.IsUserEnabled = true;
            _view.Chart0_Kren.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            _view.Chart0_Kren.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            _view.Chart0_Kren.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            for (int i = 0; i < model.Times.Count - 1; i++)
            {
                _view.Chart0_Kren.Series[0].Points.AddXY(model.Times[i], model.Kren0[i]);
            }

            _view.Chart0_Kurs.ChartAreas[0].AxisX.ScaleView.Zoom(0, 120);
            _view.Chart0_Kurs.ChartAreas[0].CursorX.IsUserEnabled = true;
            _view.Chart0_Kurs.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            _view.Chart0_Kurs.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            _view.Chart0_Kurs.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            _view.Chart0_Kurs.ChartAreas[0].AxisY.ScaleView.Zoom(-90, 90);
            _view.Chart0_Kurs.ChartAreas[0].CursorY.IsUserEnabled = true;
            _view.Chart0_Kurs.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            _view.Chart0_Kurs.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            _view.Chart0_Kurs.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            for (int i = 0; i < model.Times.Count - 1; i++)
            {
                _view.Chart0_Kurs.Series[0].Points.AddXY(model.Times[i], model.Kurs0[i]);
            }

            _view.Chart0_Tangazh.ChartAreas[0].AxisX.ScaleView.Zoom(0, 120);
            _view.Chart0_Tangazh.ChartAreas[0].CursorX.IsUserEnabled = true;
            _view.Chart0_Tangazh.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            _view.Chart0_Tangazh.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            _view.Chart0_Tangazh.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            _view.Chart0_Tangazh.ChartAreas[0].AxisY.ScaleView.Zoom(-90, 90);
            _view.Chart0_Tangazh.ChartAreas[0].CursorY.IsUserEnabled = true;
            _view.Chart0_Tangazh.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            _view.Chart0_Tangazh.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            _view.Chart0_Tangazh.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            for (int i = 0; i < model.Times.Count - 1; i++)
            {
                _view.Chart0_Tangazh.Series[0].Points.AddXY(model.Times[i], model.Tangazh0[i]);
            }
        }

       
    }
}
