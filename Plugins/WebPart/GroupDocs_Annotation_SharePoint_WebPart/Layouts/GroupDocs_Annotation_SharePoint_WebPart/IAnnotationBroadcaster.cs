﻿using System;
using System.Collections.Generic;
using GroupDocs.Annotation.Domain;
using GroupDocs_Annotation_SharePoint_WebPart.BusinessLogic.Options;
using AnnotationInfo = GroupDocs_Annotation_SharePoint_WebPart.AnnotationResults.Data.AnnotationInfo;
using AnnotationReplyInfo = GroupDocs_Annotation_SharePoint_WebPart.AnnotationResults.Data.AnnotationReplyInfo;
using Point = GroupDocs_Annotation_SharePoint_WebPart.AnnotationResults.DataGeometry.Point;
using Rectangle = GroupDocs_Annotation_SharePoint_WebPart.AnnotationResults.DataGeometry.Rectangle;
using ReviewerInfo = GroupDocs_Annotation_SharePoint_WebPart.AnnotationResults.Data.ReviewerInfo;

namespace GroupDocs_Annotation_SharePoint_WebPart
{
    public interface IAnnotationBroadcaster
    {
        void CreateAnnotation(IList<string> collaboratorGuids,
                              string connectionIdToExclude,
                              string userGuid,
                              string userName,
                              string documentGuid,
                              AnnotationType annotationType,
                              string annotationGuid,
                              byte access,
                              string replyGuid,
                              int pageNumber,
                              Rectangle box,
                              Point? annotationPosition,
                              string svgPath,
                              DrawingOptions options,
                              FontOptions font);

        void AddAnnotationReply(IList<string> collaboratorGuids,
                                 string connectionIdToExclude,
                                 string userGuid,
                                 string userName,
                                 string annotationGuid,
                                 string replyGuid,
                                 string parentReplyGuid,
                                 DateTime replyDateTime,
                                 string text);
        void SetReviewersColors(IList<string> collaboratorGuids, string connectionIdToExclude, ReviewerInfo[] reviewerDescriptions);
        void SetReviewersRights(IList<string> collaboratorGuids, string connectionIdToExclude, ReviewerInfo[] reviewerDescriptions);

        void ResizeAnnotation(IList<string> collaboratorGuids, string documentGuid, string connectionIdToExclude, string annotationGuid, double width, double height);
        void SetTextFieldColor(IList<string> collaboratorGuids, string documentGuid, string connectionIdToExclude, string annotationGuid, int fontColor);
        void SetAnnotationBackgroundColor(IList<string> collaboratorGuids, string documentGuid, string connectionIdToExclude, string annotationGuid, int color);
        void DeleteAnnotation(IList<string> collaboratorGuids, string documentGuid, string connectionIdToExclude, string annotationGuid);
        void MoveAnnotationMarker(IList<string> collaboratorGuids, string connectionIdToExclude, string annotationGuid, Point position, int? pageNumber);
        void DeleteAnnotationReply(IList<string> collaboratorGuids, string connectionIdToExclude, string annotationGuid, string replyGuid, AnnotationReplyInfo[] replies);
        void EditAnnotationReply(IList<string> collaboratorGuids, string connectionIdToExclude, string annotationGuid, string replyGuid, string message);
        void UpdateTextField(IList<string> collaboratorGuids, string connectionIdToExclude, string annotationGuid,
                             string text, string fontFamily, double? fontSize);
        void SetAnnotationAccess(IList<string> collaboratorGuids, string connectionIdToExclude, string annotationGuid, byte annotationAccess, AnnotationInfo annotation);
        void MoveAnnotation(IList<string> collaboratorGuids, string connectionIdToExclude, string annotationGuid, int pageNumber, Point position);

        void SetUserGuidForConnection(string connectionGuid, string userGuid);
        DocumentReviewer? GetConnectionUser(string connectionId);
    }
}
