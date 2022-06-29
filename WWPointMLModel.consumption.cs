﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace WWPointPredictor
{
    public partial class WWPointMLModel
    {
        /// <summary>
        /// model input class for WWPointMLModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"P+ Unrounded")]
            public float P__Unrounded { get; set; }

            [ColumnName(@"Calories")]
            public float Calories { get; set; }

            [ColumnName(@"Fat (g)")]
            public float Fat__g_ { get; set; }

            [ColumnName(@"Sat Fat (g)")]
            public float Sat_Fat__g_ { get; set; }

            [ColumnName(@"Trans Fat (g)")]
            public float Trans_Fat__g_ { get; set; }

            [ColumnName(@"Cholest (mg)")]
            public float Cholest__mg_ { get; set; }

            [ColumnName(@"Sodium (mg)")]
            public float Sodium__mg_ { get; set; }

            [ColumnName(@"Carb (g)")]
            public float Carb__g_ { get; set; }

            [ColumnName(@"Fiber (g)")]
            public float Fiber__g_ { get; set; }

            [ColumnName(@"Sugars (g)")]
            public float Sugars__g_ { get; set; }

            [ColumnName(@"Protein (g)")]
            public float Protein__g_ { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for WWPointMLModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            public float Score { get; set; }
        }
        #endregion

        private static string MLNetModelPath = Path.GetFullPath("WWPointMLModel.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
