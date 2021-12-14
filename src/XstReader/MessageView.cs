﻿// Copyright (c) 2016,2019,2020, Dijji, and released under Ms-PL.  This can be found in the root of this distribution. 

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace XstReader
{
    // Provides a view of a Message object for the UI

    public class MessageView : INotifyPropertyChanged
    {
        private bool isSelected = false;

        public MessageView(XstMessage message)
        {
            if (message == null)
                throw new XstException("MessageView requires a Message object");
            Message = message;
        }

        public XstMessage Message { get; private set; }
        public string From => Message.From; 
        public string To => Message.To; 
        public string Cc => Message.Cc; 
        public string FromTo => Message.Folder.Name.StartsWith("Sent") ? To : From; 
        public string Subject => Message.Subject;
        public DateTime? Received => Message.Received; 
        public DateTime? Submitted => Message.Submitted; 
        public DateTime? Modified => Message.Modified; // When any attachment was last modified
        public DateTime? Date => Received ?? Submitted; 
        public string DisplayDate => Date != null ? ((DateTime)Date).ToString("g") : "<unknown>"; 
        public string Body => Message.Body;
        public string BodyHtml => Message.BodyHtml; 
        public byte[] Html => Message.Html; 
        public byte[] RtfCompressed => Message.RtfCompressed; 
        public ObservableCollection<XstAttachment> Attachments { get; private set; } = new ObservableCollection<XstAttachment>();
        public List<XstRecipient> Recipients => Message.Recipients; 
        public List<XstProperty> Properties => Message.Properties; 
        public bool MayHaveInlineAttachment => Message.MayHaveInlineAttachment; 
        public bool IsEncryptedOrSigned => Message.IsEncryptedOrSigned; 

        // The following properties are used in XAML bindings to control the UI
        public bool HasAttachment => Message.HasAttachment; 
        public bool HasFileAttachment => Message.HasFileAttachment; 
        public bool HasVisibleFileAttachment => Message.HasVisibleFileAttachment; 
        public bool HasEmailAttachment => Attachments.Any(a => a.IsEmail); 
        public bool ShowText => Message.IsBodyText;
        public bool ShowHtml => Message.IsBodyHtml; 
        public bool ShowRtf => Message.IsBodyRtf; 

        public bool HasToDisplayList => ToDisplayList.Length > 0; 
        public string ToDisplayList => Message.ToDisplayList; 
        public bool HasCcDisplayList => CcDisplayList.Length > 0; 
        public string CcDisplayList => Message.CcDisplayList; 
        public bool HasBccDisplayList => BccDisplayList.Length > 0; 
        public string BccDisplayList => Message.BccDisplayList; 
        public string FileAttachmentDisplayList => Message.FileAttachmentDisplayList;
        public string ExportFileName => Message.ExportFileName;
        public string ExportFileExtension => Message.ExportFileExtension; 

        public bool IsSelected
        {
            get => isSelected; 
            set
            {
                if (value != isSelected)
                {
                    isSelected = value;
                    OnPropertyChanged(nameof(IsSelected));
                }
            }
        }


        public void ClearContents()
        {
            Message.ClearContents();
            Attachments.Clear();
        }

        public void ReadSignedOrEncryptedMessage()
        {
            XstAttachment a = Message.Attachments[0];

            byte[] attachmentBytes = new byte[0];

            //get attachment bytes
            using (var ms = new MemoryStream())
            {
                a.SaveToStream(ms);
                attachmentBytes = ms.ToArray();
            }

            Message.ReadSignedOrEncryptedMessage(attachmentBytes);
        }

        public void SortAndSaveAttachments(List<XstAttachment> atts = null)
        {
            // If no attachments are supplied, sort the list we already have
            if (atts == null)
                atts = new List<XstAttachment>(Attachments);

            atts.Sort((a, b) =>
            {
                if (a == null)
                    return -1;
                else if (b == null)
                    return 1;
                else if (a.Hide != b.Hide)
                    return a.Hide ? 1 : -1;
                else
                    return 0;
            });

            Attachments.Clear();
            foreach (var a in atts)
                Attachments.Add(a);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

    }

}
