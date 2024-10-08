using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 前端收到世界信息 message
 */
public class ResSendWorldMessage : Message 
{
	//发送消息的玩家
	long _playerId;	
	//发送消息的玩家名称
	string _playerName;	
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
		SerializeUtils.WriteLong(stream, _playerId);
		//发送消息的玩家名称
		SerializeUtils.WriteString(stream, _playerName);
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
		_playerId = SerializeUtils.ReadLong(stream);
		//发送消息的玩家名称
		_playerName = SerializeUtils.ReadString(stream);
		//0:普通聊天,1:语音聊天
		_type = SerializeUtils.ReadInt(stream);
		//消息内容
		_content = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 发送消息的玩家
	 */
	public long PlayerId
	{
		set { _playerId = value; }
	    get { return _playerId; }
	}
	
	/**
	 * 发送消息的玩家名称
	 */
	public string PlayerName
	{
		set { _playerName = value; }
	    get { return _playerName; }
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
		return 307104;
	}
}