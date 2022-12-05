using Blazor.Extensions.Canvas.Canvas2D;
using System.Diagnostics;
using TheMall.Data.Modles;

namespace TheMall.Data
{
    public class Canvas
    {
        /// <summary>
        /// Draw map to the ctx
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="components"></param>
        /// <param name="baseStrokeColor"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public async void DrawMap(Canvas2DContext ctx, List<ComponentV> components, string baseStrokeColor, double width, double height)
        {
            await ctx.SetStrokeStyleAsync(baseStrokeColor);
            await ctx.ClearRectAsync(0, 0, width, height).ConfigureAwait(false);
            bool firstDraw = true;
            await ctx.SetTransformAsync(1, 0, 0, 1, 0, 0);
            await ctx.BeginBatchAsync();
            for (int j = 0; j < components.Count; j++)
            {

                for (int x = 0; x < components[j].Geodata.XInput.Length; x++)
                {
                    if (firstDraw == true)
                    {
                        await ctx.BeginPathAsync();
                        await ctx.MoveToAsync(components[j].Geodata.XInput[x], components[j].Geodata.YInput[x]);
                        firstDraw = false;
                    }
                    else
                    {
                        await ctx.LineToAsync(components[j].Geodata.XInput[x], components[j].Geodata.YInput[x]);
                        await ctx.StrokeAsync();
                    }
                }

                await ctx.ClosePathAsync();

                firstDraw = true;
            }
            await ctx.EndBatchAsync();
           
        }
    }

}

