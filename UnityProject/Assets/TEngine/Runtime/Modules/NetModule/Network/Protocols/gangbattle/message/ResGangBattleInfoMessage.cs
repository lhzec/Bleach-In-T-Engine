using System.IO;
using System.Collections.Generic;

/** 
 * @author xml file generate by free marker
 * 
 * 番队战信息 message
 */
public class ResGangBattleInfoMessage : Message 
{
	//番队战信息
	GangBattleInfo _gangBattleInfo;	
	
	/**
	 * 序列化
	 */
	public override void Serialize(Stream stream)
	{
		//番队战信息
		SerializeUtils.WriteBean(stream, _gangBattleInfo);
	}
	
	/**
	 * 反序列化
	 */
	public override void Deserialize(Stream stream)
	{
		//番队战信息
		_gangBattleInfo = SerializeUtils.ReadBean<GangBattleInfo>(stream);
	}
	
	/**
	 * 番队战信息
	 */
	public GangBattleInfo GangBattleInfo
	{
		set { _gangBattleInfo = value; }
	    get { return _gangBattleInfo; }
	}
	
	
	public override int GetId() 
	{
		return 112110;
	}
}