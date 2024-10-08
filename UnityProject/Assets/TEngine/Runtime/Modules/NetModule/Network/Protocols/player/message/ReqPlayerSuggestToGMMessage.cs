using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 玩家向GM发送建议信息请求 message
 */
public class ReqPlayerSuggestToGMMessage : Message 
{
	//玩家建议信息
	string _suggestMsg;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//玩家建议信息
		SerializeUtils.WriteString(stream, _suggestMsg);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//玩家建议信息
		_suggestMsg = SerializeUtils.ReadString(stream);
	}
	
	/**
	 * 玩家建议信息
	 */
	public string SuggestMsg
	{
		set { _suggestMsg = value; }
	    get { return _suggestMsg; }
	}
	
	
	public override int GetId() 
	{
		return 105205;
	}
}