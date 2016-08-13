﻿#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Text;
using OpenSource.UPnP;

namespace FreeMi.Core
{
    /// <summary>
    /// Transparent DeviceSide UPnP Service
    /// </summary>
    internal class ConnectionManager : IUPnPService
    {
        // Place your declarations above this line

        #region AutoGenerated Code Section [Do NOT Modify, unless you know what you're doing]

        //{{{{{ Begin Code Block

        private _DvConnectionManager _S;
        public static string URN = "urn:schemas-upnp-org:service:ConnectionManager:1";

        public double VERSION
        {
            get { return (double.Parse(_S.GetUPnPService().Version)); }
        }

        public enum Enum_A_ARG_TYPE_Direction
        {
            INPUT,
            OUTPUT,
        }

        public Enum_A_ARG_TYPE_Direction A_ARG_TYPE_Direction
        {
            set
            {
                string v = "";
                switch (value)
                {
                    case Enum_A_ARG_TYPE_Direction.INPUT:
                        v = "Input";
                        break;
                    case Enum_A_ARG_TYPE_Direction.OUTPUT:
                        v = "Output";
                        break;
                }
                _S.SetStateVariable("A_ARG_TYPE_Direction", v);
            }
            get
            {
                Enum_A_ARG_TYPE_Direction RetVal = 0;
                string v = (string) _S.GetStateVariable("A_ARG_TYPE_Direction");
                switch (v)
                {
                    case "Input":
                        RetVal = Enum_A_ARG_TYPE_Direction.INPUT;
                        break;
                    case "Output":
                        RetVal = Enum_A_ARG_TYPE_Direction.OUTPUT;
                        break;
                }
                return (RetVal);
            }
        }

        public enum Enum_A_ARG_TYPE_ConnectionStatus
        {
            OK,
            CONTENTFORMATMISMATCH,
            INSUFFICIENTBANDWIDTH,
            UNRELIABLECHANNEL,
            UNKNOWN,
        }

        public Enum_A_ARG_TYPE_ConnectionStatus A_ARG_TYPE_ConnectionStatus
        {
            set
            {
                string v = "";
                switch (value)
                {
                    case Enum_A_ARG_TYPE_ConnectionStatus.OK:
                        v = "OK";
                        break;
                    case Enum_A_ARG_TYPE_ConnectionStatus.CONTENTFORMATMISMATCH:
                        v = "ContentFormatMismatch";
                        break;
                    case Enum_A_ARG_TYPE_ConnectionStatus.INSUFFICIENTBANDWIDTH:
                        v = "InsufficientBandwidth";
                        break;
                    case Enum_A_ARG_TYPE_ConnectionStatus.UNRELIABLECHANNEL:
                        v = "UnreliableChannel";
                        break;
                    case Enum_A_ARG_TYPE_ConnectionStatus.UNKNOWN:
                        v = "Unknown";
                        break;
                }
                _S.SetStateVariable("A_ARG_TYPE_ConnectionStatus", v);
            }
            get
            {
                Enum_A_ARG_TYPE_ConnectionStatus RetVal = 0;
                string v = (string) _S.GetStateVariable("A_ARG_TYPE_ConnectionStatus");
                switch (v)
                {
                    case "OK":
                        RetVal = Enum_A_ARG_TYPE_ConnectionStatus.OK;
                        break;
                    case "ContentFormatMismatch":
                        RetVal = Enum_A_ARG_TYPE_ConnectionStatus.CONTENTFORMATMISMATCH;
                        break;
                    case "InsufficientBandwidth":
                        RetVal = Enum_A_ARG_TYPE_ConnectionStatus.INSUFFICIENTBANDWIDTH;
                        break;
                    case "UnreliableChannel":
                        RetVal = Enum_A_ARG_TYPE_ConnectionStatus.UNRELIABLECHANNEL;
                        break;
                    case "Unknown":
                        RetVal = Enum_A_ARG_TYPE_ConnectionStatus.UNKNOWN;
                        break;
                }
                return (RetVal);
            }
        }

        public static string Enum_A_ARG_TYPE_Direction_ToString(Enum_A_ARG_TYPE_Direction en)
        {
            string RetVal = "";
            switch (en)
            {
                case Enum_A_ARG_TYPE_Direction.INPUT:
                    RetVal = "Input";
                    break;
                case Enum_A_ARG_TYPE_Direction.OUTPUT:
                    RetVal = "Output";
                    break;
            }
            return (RetVal);
        }

        public static string[] Values_A_ARG_TYPE_Direction
        {
            get
            {
                string[] RetVal = new string[2] { "Output", "Input" };
                return (RetVal);
            }
        }

        public static string Enum_A_ARG_TYPE_ConnectionStatus_ToString(Enum_A_ARG_TYPE_ConnectionStatus en)
        {
            string RetVal = "";
            switch (en)
            {
                case Enum_A_ARG_TYPE_ConnectionStatus.OK:
                    RetVal = "OK";
                    break;
                case Enum_A_ARG_TYPE_ConnectionStatus.CONTENTFORMATMISMATCH:
                    RetVal = "ContentFormatMismatch";
                    break;
                case Enum_A_ARG_TYPE_ConnectionStatus.INSUFFICIENTBANDWIDTH:
                    RetVal = "InsufficientBandwidth";
                    break;
                case Enum_A_ARG_TYPE_ConnectionStatus.UNRELIABLECHANNEL:
                    RetVal = "UnreliableChannel";
                    break;
                case Enum_A_ARG_TYPE_ConnectionStatus.UNKNOWN:
                    RetVal = "Unknown";
                    break;
            }
            return (RetVal);
        }

        public static string[] Values_A_ARG_TYPE_ConnectionStatus
        {
            get
            {
                string[] RetVal = new string[5] { "Unknown", "UnreliableChannel", "InsufficientBandwidth", "ContentFormatMismatch", "OK" };
                return (RetVal);
            }
        }

        public delegate void OnStateVariableModifiedHandler(ConnectionManager sender);

        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_ConnectionManager;
        public event OnStateVariableModifiedHandler OnStateVariableModified_SinkProtocolInfo;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_ConnectionStatus;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_AVTransportID;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_Direction;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_RcsID;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_ProtocolInfo;
        public event OnStateVariableModifiedHandler OnStateVariableModified_A_ARG_TYPE_ConnectionID;
        public event OnStateVariableModifiedHandler OnStateVariableModified_SourceProtocolInfo;
        public event OnStateVariableModifiedHandler OnStateVariableModified_CurrentConnectionIDs;

        public System.String A_ARG_TYPE_ConnectionManager
        {
            get { return ((System.String) _S.GetStateVariable("A_ARG_TYPE_ConnectionManager")); }
            set { _S.SetStateVariable("A_ARG_TYPE_ConnectionManager", value); }
        }

        public System.String Evented_SinkProtocolInfo
        {
            get { return ((System.String) _S.GetStateVariable("SinkProtocolInfo")); }
            set { _S.SetStateVariable("SinkProtocolInfo", value); }
        }

        public System.Int32 A_ARG_TYPE_AVTransportID
        {
            get { return ((System.Int32) _S.GetStateVariable("A_ARG_TYPE_AVTransportID")); }
            set { _S.SetStateVariable("A_ARG_TYPE_AVTransportID", value); }
        }

        public System.Int32 A_ARG_TYPE_RcsID
        {
            get { return ((System.Int32) _S.GetStateVariable("A_ARG_TYPE_RcsID")); }
            set { _S.SetStateVariable("A_ARG_TYPE_RcsID", value); }
        }

        public System.String A_ARG_TYPE_ProtocolInfo
        {
            get { return ((System.String) _S.GetStateVariable("A_ARG_TYPE_ProtocolInfo")); }
            set { _S.SetStateVariable("A_ARG_TYPE_ProtocolInfo", value); }
        }

        public System.Int32 A_ARG_TYPE_ConnectionID
        {
            get { return ((System.Int32) _S.GetStateVariable("A_ARG_TYPE_ConnectionID")); }
            set { _S.SetStateVariable("A_ARG_TYPE_ConnectionID", value); }
        }

        public System.String Evented_SourceProtocolInfo
        {
            get { return ((System.String) _S.GetStateVariable("SourceProtocolInfo")); }
            set { _S.SetStateVariable("SourceProtocolInfo", value); }
        }

        public System.String Evented_CurrentConnectionIDs
        {
            get { return ((System.String) _S.GetStateVariable("CurrentConnectionIDs")); }
            set { _S.SetStateVariable("CurrentConnectionIDs", value); }
        }

        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_ConnectionManager
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionManager")).Accumulator); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionManager")).Accumulator = value; }
        }

        public double ModerationDuration_A_ARG_TYPE_ConnectionManager
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionManager")).ModerationPeriod); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionManager")).ModerationPeriod = value; }
        }

        public UPnPModeratedStateVariable.IAccumulator Accumulator_SinkProtocolInfo
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("SinkProtocolInfo")).Accumulator); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("SinkProtocolInfo")).Accumulator = value; }
        }

        public double ModerationDuration_SinkProtocolInfo
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("SinkProtocolInfo")).ModerationPeriod); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("SinkProtocolInfo")).ModerationPeriod = value; }
        }

        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_ConnectionStatus
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionStatus")).Accumulator); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionStatus")).Accumulator = value; }
        }

        public double ModerationDuration_A_ARG_TYPE_ConnectionStatus
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionStatus")).ModerationPeriod); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionStatus")).ModerationPeriod = value; }
        }

        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_AVTransportID
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_AVTransportID")).Accumulator); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_AVTransportID")).Accumulator = value; }
        }

        public double ModerationDuration_A_ARG_TYPE_AVTransportID
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_AVTransportID")).ModerationPeriod); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_AVTransportID")).ModerationPeriod = value; }
        }

        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_Direction
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Direction")).Accumulator); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Direction")).Accumulator = value; }
        }

        public double ModerationDuration_A_ARG_TYPE_Direction
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Direction")).ModerationPeriod); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Direction")).ModerationPeriod = value; }
        }

        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_RcsID
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_RcsID")).Accumulator); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_RcsID")).Accumulator = value; }
        }

        public double ModerationDuration_A_ARG_TYPE_RcsID
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_RcsID")).ModerationPeriod); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_RcsID")).ModerationPeriod = value; }
        }

        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_ProtocolInfo
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ProtocolInfo")).Accumulator); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ProtocolInfo")).Accumulator = value; }
        }

        public double ModerationDuration_A_ARG_TYPE_ProtocolInfo
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ProtocolInfo")).ModerationPeriod); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ProtocolInfo")).ModerationPeriod = value; }
        }

        public UPnPModeratedStateVariable.IAccumulator Accumulator_A_ARG_TYPE_ConnectionID
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionID")).Accumulator); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionID")).Accumulator = value; }
        }

        public double ModerationDuration_A_ARG_TYPE_ConnectionID
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionID")).ModerationPeriod); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionID")).ModerationPeriod = value; }
        }

        public UPnPModeratedStateVariable.IAccumulator Accumulator_SourceProtocolInfo
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("SourceProtocolInfo")).Accumulator); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("SourceProtocolInfo")).Accumulator = value; }
        }

        public double ModerationDuration_SourceProtocolInfo
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("SourceProtocolInfo")).ModerationPeriod); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("SourceProtocolInfo")).ModerationPeriod = value; }
        }

        public UPnPModeratedStateVariable.IAccumulator Accumulator_CurrentConnectionIDs
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("CurrentConnectionIDs")).Accumulator); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("CurrentConnectionIDs")).Accumulator = value; }
        }

        public double ModerationDuration_CurrentConnectionIDs
        {
            get { return (((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("CurrentConnectionIDs")).ModerationPeriod); }
            set { ((UPnPModeratedStateVariable) _S.GetUPnPService().GetStateVariableObject("CurrentConnectionIDs")).ModerationPeriod = value; }
        }

        public delegate void Delegate_ConnectionComplete(System.Int32 ConnectionID);

        public delegate void Delegate_GetCurrentConnectionIDs(out System.String ConnectionIDs);

        public delegate void Delegate_GetCurrentConnectionInfo(System.Int32 ConnectionID, out System.Int32 RcsID, out System.Int32 AVTransportID, out System.String ProtocolInfo, out System.String PeerConnectionManager, out System.Int32 PeerConnectionID, out ConnectionManager.Enum_A_ARG_TYPE_Direction Direction, out ConnectionManager.Enum_A_ARG_TYPE_ConnectionStatus Status);

        public delegate void Delegate_GetProtocolInfo(out System.String Source, out System.String Sink);

        public delegate void Delegate_PrepareForConnection(System.String RemoteProtocolInfo, System.String PeerConnectionManager, System.Int32 PeerConnectionID, ConnectionManager.Enum_A_ARG_TYPE_Direction Direction, out System.Int32 ConnectionID, out System.Int32 AVTransportID, out System.Int32 RcsID);

        public Delegate_ConnectionComplete External_ConnectionComplete = null;
        public Delegate_GetCurrentConnectionIDs External_GetCurrentConnectionIDs = null;
        public Delegate_GetCurrentConnectionInfo External_GetCurrentConnectionInfo = null;
        public Delegate_GetProtocolInfo External_GetProtocolInfo = null;
        public Delegate_PrepareForConnection External_PrepareForConnection = null;

        public void RemoveStateVariable_A_ARG_TYPE_ConnectionManager()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionManager"));
        }

        public void RemoveStateVariable_SinkProtocolInfo()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("SinkProtocolInfo"));
        }

        public void RemoveStateVariable_A_ARG_TYPE_ConnectionStatus()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionStatus"));
        }

        public void RemoveStateVariable_A_ARG_TYPE_AVTransportID()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_AVTransportID"));
        }

        public void RemoveStateVariable_A_ARG_TYPE_Direction()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Direction"));
        }

        public void RemoveStateVariable_A_ARG_TYPE_RcsID()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_RcsID"));
        }

        public void RemoveStateVariable_A_ARG_TYPE_ProtocolInfo()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ProtocolInfo"));
        }

        public void RemoveStateVariable_A_ARG_TYPE_ConnectionID()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionID"));
        }

        public void RemoveStateVariable_SourceProtocolInfo()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("SourceProtocolInfo"));
        }

        public void RemoveStateVariable_CurrentConnectionIDs()
        {
            _S.GetUPnPService().RemoveStateVariable(_S.GetUPnPService().GetStateVariableObject("CurrentConnectionIDs"));
        }

        public void RemoveAction_ConnectionComplete()
        {
            _S.GetUPnPService().RemoveMethod("ConnectionComplete");
        }

        public void RemoveAction_GetCurrentConnectionIDs()
        {
            _S.GetUPnPService().RemoveMethod("GetCurrentConnectionIDs");
        }

        public void RemoveAction_GetCurrentConnectionInfo()
        {
            _S.GetUPnPService().RemoveMethod("GetCurrentConnectionInfo");
        }

        public void RemoveAction_GetProtocolInfo()
        {
            _S.GetUPnPService().RemoveMethod("GetProtocolInfo");
        }

        public void RemoveAction_PrepareForConnection()
        {
            _S.GetUPnPService().RemoveMethod("PrepareForConnection");
        }

        public System.Net.IPEndPoint GetCaller()
        {
            return (_S.GetUPnPService().GetCaller());
        }

        public System.Net.IPEndPoint GetReceiver()
        {
            return (_S.GetUPnPService().GetReceiver());
        }

        private class _DvConnectionManager
        {
            private ConnectionManager Outer = null;
            private UPnPService S;

            internal _DvConnectionManager(ConnectionManager n)
            {
                Outer = n;
                S = BuildUPnPService();
            }

            public UPnPService GetUPnPService()
            {
                return (S);
            }

            public void SetStateVariable(string VarName, object VarValue)
            {
                S.SetStateVariable(VarName, VarValue);
            }

            public object GetStateVariable(string VarName)
            {
                return (S.GetStateVariable(VarName));
            }

            protected UPnPService BuildUPnPService()
            {
                UPnPStateVariable[] RetVal = new UPnPStateVariable[10];
                RetVal[0] = new UPnPModeratedStateVariable("A_ARG_TYPE_ConnectionManager", typeof (System.String), false);
                RetVal[0].AddAssociation("GetCurrentConnectionInfo", "PeerConnectionManager");
                RetVal[0].AddAssociation("PrepareForConnection", "PeerConnectionManager");
                RetVal[1] = new UPnPModeratedStateVariable("SinkProtocolInfo", typeof (System.String), true);
                RetVal[1].AddAssociation("GetProtocolInfo", "Sink");
                RetVal[2] = new UPnPModeratedStateVariable("A_ARG_TYPE_ConnectionStatus", typeof (System.String), false);
                RetVal[2].AllowedStringValues = new string[5] { "OK", "ContentFormatMismatch", "InsufficientBandwidth", "UnreliableChannel", "Unknown" };
                RetVal[2].AddAssociation("GetCurrentConnectionInfo", "Status");
                RetVal[3] = new UPnPModeratedStateVariable("A_ARG_TYPE_AVTransportID", typeof (System.Int32), false);
                RetVal[3].AddAssociation("GetCurrentConnectionInfo", "AVTransportID");
                RetVal[3].AddAssociation("PrepareForConnection", "AVTransportID");
                RetVal[4] = new UPnPModeratedStateVariable("A_ARG_TYPE_Direction", typeof (System.String), false);
                RetVal[4].AllowedStringValues = new string[2] { "Input", "Output" };
                RetVal[4].AddAssociation("GetCurrentConnectionInfo", "Direction");
                RetVal[4].AddAssociation("PrepareForConnection", "Direction");
                RetVal[5] = new UPnPModeratedStateVariable("A_ARG_TYPE_RcsID", typeof (System.Int32), false);
                RetVal[5].AddAssociation("GetCurrentConnectionInfo", "RcsID");
                RetVal[5].AddAssociation("PrepareForConnection", "RcsID");
                RetVal[6] = new UPnPModeratedStateVariable("A_ARG_TYPE_ProtocolInfo", typeof (System.String), false);
                RetVal[6].AddAssociation("GetCurrentConnectionInfo", "ProtocolInfo");
                RetVal[6].AddAssociation("PrepareForConnection", "RemoteProtocolInfo");
                RetVal[7] = new UPnPModeratedStateVariable("A_ARG_TYPE_ConnectionID", typeof (System.Int32), false);
                RetVal[7].AddAssociation("ConnectionComplete", "ConnectionID");
                RetVal[7].AddAssociation("GetCurrentConnectionInfo", "ConnectionID");
                RetVal[7].AddAssociation("GetCurrentConnectionInfo", "PeerConnectionID");
                RetVal[7].AddAssociation("PrepareForConnection", "PeerConnectionID");
                RetVal[7].AddAssociation("PrepareForConnection", "ConnectionID");
                RetVal[8] = new UPnPModeratedStateVariable("SourceProtocolInfo", typeof (System.String), true);
                RetVal[8].AddAssociation("GetProtocolInfo", "Source");
                RetVal[9] = new UPnPModeratedStateVariable("CurrentConnectionIDs", typeof (System.String), true);
                RetVal[9].AddAssociation("GetCurrentConnectionIDs", "ConnectionIDs");

                UPnPService S = new UPnPService(1, "urn:upnp-org:serviceId:ConnectionManager", URN, true, this);
                for (int i = 0; i < RetVal.Length; ++i)
                {
                    S.AddStateVariable(RetVal[i]);
                }
                S.AddMethod("ConnectionComplete");
                S.AddMethod("GetCurrentConnectionIDs");
                S.AddMethod("GetCurrentConnectionInfo");
                S.AddMethod("GetProtocolInfo");
                S.AddMethod("PrepareForConnection");
                return (S);
            }

            public void ConnectionComplete(System.Int32 ConnectionID)
            {
                if (Outer.External_ConnectionComplete != null)
                {
                    Outer.External_ConnectionComplete(ConnectionID);
                }
                else
                {
                    Sink_ConnectionComplete(ConnectionID);
                }
            }

            public void GetCurrentConnectionIDs(out System.String ConnectionIDs)
            {
                if (Outer.External_GetCurrentConnectionIDs != null)
                {
                    Outer.External_GetCurrentConnectionIDs(out ConnectionIDs);
                }
                else
                {
                    Sink_GetCurrentConnectionIDs(out ConnectionIDs);
                }
            }

            public void GetCurrentConnectionInfo(System.Int32 ConnectionID, out System.Int32 RcsID, out System.Int32 AVTransportID, out System.String ProtocolInfo, out System.String PeerConnectionManager, out System.Int32 PeerConnectionID, out System.String Direction, out System.String Status)
            {
                Enum_A_ARG_TYPE_Direction e_Direction;
                Enum_A_ARG_TYPE_ConnectionStatus e_Status;
                if (Outer.External_GetCurrentConnectionInfo != null)
                {
                    Outer.External_GetCurrentConnectionInfo(ConnectionID, out RcsID, out AVTransportID, out ProtocolInfo, out PeerConnectionManager, out PeerConnectionID, out e_Direction, out e_Status);
                }
                else
                {
                    Sink_GetCurrentConnectionInfo(ConnectionID, out RcsID, out AVTransportID, out ProtocolInfo, out PeerConnectionManager, out PeerConnectionID, out e_Direction, out e_Status);
                }
                switch (e_Direction)
                {
                    case Enum_A_ARG_TYPE_Direction.INPUT:
                        Direction = "Input";
                        break;
                    case Enum_A_ARG_TYPE_Direction.OUTPUT:
                        Direction = "Output";
                        break;
                    default:
                        Direction = "";
                        break;
                }
                switch (e_Status)
                {
                    case Enum_A_ARG_TYPE_ConnectionStatus.OK:
                        Status = "OK";
                        break;
                    case Enum_A_ARG_TYPE_ConnectionStatus.CONTENTFORMATMISMATCH:
                        Status = "ContentFormatMismatch";
                        break;
                    case Enum_A_ARG_TYPE_ConnectionStatus.INSUFFICIENTBANDWIDTH:
                        Status = "InsufficientBandwidth";
                        break;
                    case Enum_A_ARG_TYPE_ConnectionStatus.UNRELIABLECHANNEL:
                        Status = "UnreliableChannel";
                        break;
                    case Enum_A_ARG_TYPE_ConnectionStatus.UNKNOWN:
                        Status = "Unknown";
                        break;
                    default:
                        Status = "";
                        break;
                }
            }

            public void GetProtocolInfo(out System.String Source, out System.String Sink)
            {
                if (Outer.External_GetProtocolInfo != null)
                {
                    Outer.External_GetProtocolInfo(out Source, out Sink);
                }
                else
                {
                    Sink_GetProtocolInfo(out Source, out Sink);
                }
            }

            public void PrepareForConnection(System.String RemoteProtocolInfo, System.String PeerConnectionManager, System.Int32 PeerConnectionID, System.String Direction, out System.Int32 ConnectionID, out System.Int32 AVTransportID, out System.Int32 RcsID)
            {
                Enum_A_ARG_TYPE_Direction e_Direction;
                switch (Direction)
                {
                    case "Input":
                        e_Direction = Enum_A_ARG_TYPE_Direction.INPUT;
                        break;
                    case "Output":
                        e_Direction = Enum_A_ARG_TYPE_Direction.OUTPUT;
                        break;
                    default:
                        e_Direction = 0;
                        break;
                }
                if (Outer.External_PrepareForConnection != null)
                {
                    Outer.External_PrepareForConnection(RemoteProtocolInfo, PeerConnectionManager, PeerConnectionID, e_Direction, out ConnectionID, out AVTransportID, out RcsID);
                }
                else
                {
                    Sink_PrepareForConnection(RemoteProtocolInfo, PeerConnectionManager, PeerConnectionID, e_Direction, out ConnectionID, out AVTransportID, out RcsID);
                }
            }

            public Delegate_ConnectionComplete Sink_ConnectionComplete;
            public Delegate_GetCurrentConnectionIDs Sink_GetCurrentConnectionIDs;
            public Delegate_GetCurrentConnectionInfo Sink_GetCurrentConnectionInfo;
            public Delegate_GetProtocolInfo Sink_GetProtocolInfo;
            public Delegate_PrepareForConnection Sink_PrepareForConnection;
        }

        public ConnectionManager()
        {
            _S = new _DvConnectionManager(this);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionManager").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_ConnectionManager);
            _S.GetUPnPService().GetStateVariableObject("SinkProtocolInfo").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_SinkProtocolInfo);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionStatus").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_ConnectionStatus);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_AVTransportID").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_AVTransportID);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_Direction").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_Direction);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_RcsID").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_RcsID);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ProtocolInfo").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_ProtocolInfo);
            _S.GetUPnPService().GetStateVariableObject("A_ARG_TYPE_ConnectionID").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_A_ARG_TYPE_ConnectionID);
            _S.GetUPnPService().GetStateVariableObject("SourceProtocolInfo").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_SourceProtocolInfo);
            _S.GetUPnPService().GetStateVariableObject("CurrentConnectionIDs").OnModified += new UPnPStateVariable.ModifiedHandler(OnModifiedSink_CurrentConnectionIDs);
            _S.Sink_ConnectionComplete = new Delegate_ConnectionComplete(ConnectionComplete);
            _S.Sink_GetCurrentConnectionIDs = new Delegate_GetCurrentConnectionIDs(GetCurrentConnectionIDs);
            _S.Sink_GetCurrentConnectionInfo = new Delegate_GetCurrentConnectionInfo(GetCurrentConnectionInfo);
            _S.Sink_GetProtocolInfo = new Delegate_GetProtocolInfo(GetProtocolInfo);
            _S.Sink_PrepareForConnection = new Delegate_PrepareForConnection(PrepareForConnection);
        }

        public ConnectionManager(string ID)
            : this()
        {
            _S.GetUPnPService().ServiceID = ID;
        }

        public UPnPService GetUPnPService()
        {
            return (_S.GetUPnPService());
        }

        private void OnModifiedSink_A_ARG_TYPE_ConnectionManager(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_ConnectionManager != null) OnStateVariableModified_A_ARG_TYPE_ConnectionManager(this);
        }

        private void OnModifiedSink_SinkProtocolInfo(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_SinkProtocolInfo != null) OnStateVariableModified_SinkProtocolInfo(this);
        }

        private void OnModifiedSink_A_ARG_TYPE_ConnectionStatus(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_ConnectionStatus != null) OnStateVariableModified_A_ARG_TYPE_ConnectionStatus(this);
        }

        private void OnModifiedSink_A_ARG_TYPE_AVTransportID(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_AVTransportID != null) OnStateVariableModified_A_ARG_TYPE_AVTransportID(this);
        }

        private void OnModifiedSink_A_ARG_TYPE_Direction(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_Direction != null) OnStateVariableModified_A_ARG_TYPE_Direction(this);
        }

        private void OnModifiedSink_A_ARG_TYPE_RcsID(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_RcsID != null) OnStateVariableModified_A_ARG_TYPE_RcsID(this);
        }

        private void OnModifiedSink_A_ARG_TYPE_ProtocolInfo(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_ProtocolInfo != null) OnStateVariableModified_A_ARG_TYPE_ProtocolInfo(this);
        }

        private void OnModifiedSink_A_ARG_TYPE_ConnectionID(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_A_ARG_TYPE_ConnectionID != null) OnStateVariableModified_A_ARG_TYPE_ConnectionID(this);
        }

        private void OnModifiedSink_SourceProtocolInfo(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_SourceProtocolInfo != null) OnStateVariableModified_SourceProtocolInfo(this);
        }

        private void OnModifiedSink_CurrentConnectionIDs(UPnPStateVariable sender, object NewValue)
        {
            if (OnStateVariableModified_CurrentConnectionIDs != null) OnStateVariableModified_CurrentConnectionIDs(this);
        }

        //}}}}} End of Code Block

        #endregion

        /// <summary>
        /// Action: ConnectionComplete
        /// </summary>
        /// <param name="ConnectionID">Associated State Variable: A_ARG_TYPE_ConnectionID</param>
        public void ConnectionComplete(Int32 ConnectionID)
        {
        }

        /// <summary>
        /// Action: GetCurrentConnectionIDs
        /// </summary>
        /// <param name="ConnectionIDs">Associated State Variable: CurrentConnectionIDs</param>
        public void GetCurrentConnectionIDs(out String ConnectionIDs)
        {
            ConnectionIDs = String.Empty;
        }

        /// <summary>
        /// Action: GetCurrentConnectionInfo
        /// </summary>
        /// <param name="ConnectionID">Associated State Variable: A_ARG_TYPE_ConnectionID</param>
        /// <param name="RcsID">Associated State Variable: A_ARG_TYPE_RcsID</param>
        /// <param name="AVTransportID">Associated State Variable: A_ARG_TYPE_AVTransportID</param>
        /// <param name="ProtocolInfo">Associated State Variable: A_ARG_TYPE_ProtocolInfo</param>
        /// <param name="PeerConnectionManager">Associated State Variable: A_ARG_TYPE_ConnectionManager</param>
        /// <param name="PeerConnectionID">Associated State Variable: A_ARG_TYPE_ConnectionID</param>
        /// <param name="Direction">Associated State Variable: A_ARG_TYPE_Direction</param>
        /// <param name="Status">Associated State Variable: A_ARG_TYPE_ConnectionStatus</param>
        public void GetCurrentConnectionInfo(Int32 ConnectionID, out Int32 RcsID, out Int32 AVTransportID, out String ProtocolInfo, out String PeerConnectionManager, out Int32 PeerConnectionID, out Enum_A_ARG_TYPE_Direction Direction, out Enum_A_ARG_TYPE_ConnectionStatus Status)
        {
            RcsID = 0;
            AVTransportID = 0;
            ProtocolInfo = String.Empty;
            PeerConnectionManager = String.Empty;
            PeerConnectionID = 0;
            Direction = ConnectionManager.Enum_A_ARG_TYPE_Direction.INPUT;
            Status = ConnectionManager.Enum_A_ARG_TYPE_ConnectionStatus.OK;
        }

        /// <summary>
        /// Action: GetProtocolInfo
        /// </summary>
        /// <param name="Source">Associated State Variable: SourceProtocolInfo</param>
        /// <param name="Sink">Associated State Variable: SinkProtocolInfo</param>
        public void GetProtocolInfo(out String Source, out String Sink)
        {
            Source = String.Empty;
            Sink = String.Empty;
        }

        /// <summary>
        /// Action: PrepareForConnection
        /// </summary>
        /// <param name="RemoteProtocolInfo">Associated State Variable: A_ARG_TYPE_ProtocolInfo</param>
        /// <param name="PeerConnectionManager">Associated State Variable: A_ARG_TYPE_ConnectionManager</param>
        /// <param name="PeerConnectionID">Associated State Variable: A_ARG_TYPE_ConnectionID</param>
        /// <param name="Direction">Associated State Variable: A_ARG_TYPE_Direction</param>
        /// <param name="ConnectionID">Associated State Variable: A_ARG_TYPE_ConnectionID</param>
        /// <param name="AVTransportID">Associated State Variable: A_ARG_TYPE_AVTransportID</param>
        /// <param name="RcsID">Associated State Variable: A_ARG_TYPE_RcsID</param>
        public void PrepareForConnection(String RemoteProtocolInfo, String PeerConnectionManager, Int32 PeerConnectionID, Enum_A_ARG_TYPE_Direction Direction, out Int32 ConnectionID, out Int32 AVTransportID, out Int32 RcsID)
        {
            ConnectionID = 0;
            AVTransportID = 0;
            RcsID = 0;
        }
    }
}