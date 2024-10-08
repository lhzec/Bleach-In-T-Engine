using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 请求一键扫荡消息 message
 */
public class ReqFastMopUnlimitFightBattleMessage : Message 
{
	//极限对决编号
	int _unlimitId;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//极限对决编号
		SerializeUtils.WriteInt(stream, _unlimitId);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//极限对决编号
		_unlimitId = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 极限对决编号
	 */
	public int UnlimitId
	{
		set { _unlimitId = value; }
	    get { return _unlimitId; }
	}
	
	
	public override int GetId() 
	{
		return 221208;
	}
}