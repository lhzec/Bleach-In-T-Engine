using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战番队报名是否成功 message
 */
public class ResGangBattleGangApplyMessage : Message 
{
	//0:报名失败，1：报名成功
	int _apply;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//0:报名失败，1：报名成功
		SerializeUtils.WriteInt(stream, _apply);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//0:报名失败，1：报名成功
		_apply = SerializeUtils.ReadInt(stream);
	}
	
	/**
	 * 0:报名失败，1：报名成功
	 */
	public int Apply
	{
		set { _apply = value; }
	    get { return _apply; }
	}
	
	
	public override int GetId() 
	{
		return 112116;
	}
}