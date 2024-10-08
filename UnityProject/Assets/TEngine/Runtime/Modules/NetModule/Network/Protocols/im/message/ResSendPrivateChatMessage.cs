using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 私聊消息内容 message
 */
public class ResSendPrivateChatMessage : Message 
{
	//发送消息的玩家
	long _fromPlayerId;	
	//发送消息的玩家名称
	string _fromPlayerName;	
	//接受消息的玩家
	long _toPlayerId;	
	//接受消息的玩家名称
	string _toPlayerName;	
	//0:普通聊天,1:语音聊天
	int _type;	
	//消息内容
	string _content;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//发送消息的玩家
		SerializeUtils.WriteLong(stream, _fromPlayerId);
		//发送消息的玩家名称
		SerializeUtils.WriteString(stream, _fromPlayerName);
		//接受消息的玩家
		SerializeUtils.WriteLong(stream, _toPlayerId);
		//接受消息的玩家名称
		SerializeUtils.WriteString(stream, _toPlayerName);
		//0:普通聊天,1:语音聊天
		SerializeUtils.WriteInt(stream, _type);
		//消息内容
		SerializeUtils.WriteString(stream, _content);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//发送消息的玩家
		_fromPlayerId = SerializeUtils.ReadLong(stream);
		//发送消息的玩家名称
		_fromPlayerName = SerializeUtils.ReadString(stream);
		//接受消息的玩家
		_toPlayerId = SerializeUtils.ReadLong(stream);
		//接受消息的玩家名称
		_toPlayerName = SerializeUtils.ReadString(stream);
		//0:普通聊天,1:语音聊天
		_type = SerializeUtils.ReadInt(stream);
		//消息内容
		_content = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 发送消息的玩家
	 */
	public long FromPlayerId
	{
		set { _fromPlayerId = value; }
	    get { return _fromPlayerId; }
	}
	
	/**
	 * 发送消息的玩家名称
	 */
	public string FromPlayerName
	{
		set { _fromPlayerName = value; }
	    get { return _fromPlayerName; }
	}
	
	/**
	 * 接受消息的玩家
	 */
	public long ToPlayerId
	{
		set { _toPlayerId = value; }
	    get { return _toPlayerId; }
	}
	
	/**
	 * 接受消息的玩家名称
	 */
	public string ToPlayerName
	{
		set { _toPlayerName = value; }
	    get { return _toPlayerName; }
	}
	
	/**
	 * 0:普通聊天,1:语音聊天
	 */
	public int Type
	{
		set { _type = value; }
	    get { return _type; }
	}
	
	/**
	 * 消息内容
	 */
	public string Content
	{
		set { _content = value; }
	    get { return _content; }
	}
	
	
	public override int GetId() 
	{
		return 307102;
	}
}