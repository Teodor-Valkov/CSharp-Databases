﻿namespace PhotoShare.Client.Utilities
{
    using System;

    // Transforms given tag to a valid one by rules
    internal static class TagUtilities
    {
        private const int DefaultLength = 20;

        // Transforms given wrong tag to a valid one by:
        // 1. removing all white spaces
        // 2. adding pound ('#') sign if needed
        // 3. reduces its length to 20 symbols if it is more
        
        // With using Extention - той се закача към всеки string;
        public static string ValidateOrTransform(this string wrongTag)
        {
        // Without using Extention: 
        //public static string ValidateOrTransform(string wrongTag)
        //{
            if (string.IsNullOrWhiteSpace(wrongTag))
            {
                throw new InvalidOperationException("Cannot convert empty string to a valid tag!");
            }

            string transformedTag = wrongTag;
            
            transformedTag = RemoveAllWhiteSpaces(transformedTag);

            if (wrongTag[0] != '#')
            {
                transformedTag = AppendPoundSign(transformedTag);
            }

            if (transformedTag.Length > DefaultLength)
            {
                transformedTag = ReduceStringLength(transformedTag, DefaultLength);
            }

            return transformedTag;
        }

        private static string RemoveAllWhiteSpaces(string tag)
        {
            string newTag = tag.Replace(" ", string.Empty)
                .Replace("\t", string.Empty)
                .Replace("\n", string.Empty)
                .Replace("\r", string.Empty);

            return newTag;
        }

        private static string AppendPoundSign(string tag)
        {
            return "#" + tag;
        }

        private static string ReduceStringLength(string tag, int length)
        {
            string reducedString = tag.Substring(0, length);
            return reducedString;
        }
    }
}